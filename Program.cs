
using DotNet.Utilities;
using Newtonsoft.Json;
using SufeiNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Test> ls = new List<Test>();
            filedouyin(ls);
            postdouyin(ls);
            ls = paixu(ls);
            go(ls);
            using (StreamWriter sw = new StreamWriter(pua, false))
            {
                foreach (var item in ls)
                {
                    sw.WriteLine(item.work + "|" + item.hot + "|" + item.ID + "|" + item.name + "\r\n");
                }

            }
        }

        public static string pua = @"acc/" + DateTime.Now.ToString("yyyyMMdd") + ".md";


        public static void postdouyin(List<Test> ls)
        {
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://aweme.snssdk.com/aweme/v1/hot/search/list/?detail_list=1";
            string html = hh.GetHtml(hi);
            SufeiNet_Test rb = JsonConvert.DeserializeObject<SufeiNet_Test>(html);
            if (rb.Data != null)
            {
                if (rb.Data.WordList != null && rb.Data.WordList.Count > 0)
                {
                    foreach (var item in rb.Data.WordList)
                    {
                        if (item.HotValue != null && item.Word != null)
                        {
                            if (!ls.Exists(t => t.work.Contains(item.Word)))
                            {
                                ls.Add( new Test() { work= item.Word,hot= item.HotValue });
                                
                            }
                            else
                            {
                                for (int i = 0; i < ls.Count; i++)
                                {
                                    if (ls[i].work== item.Word)
                                    {
                                        ls[i].hot = item.HotValue;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public static List<Test> paixu(List<Test> ls)
        {
            ls = ls.OrderByDescending(o => o.hot.Length).ThenByDescending(o => o.hot).ToList();
            return ls;
        }

        public static void filedouyin(List<Test> ls)
        {
            if (!Directory.Exists("acc"))
            {
                Directory.CreateDirectory("acc");
            }
            if (!File.Exists(pua))
            {
                FileStream fs1 = new FileStream(pua, FileMode.Create, FileAccess.Write);
            }
            else
            {
                using (StreamReader sr = new StreamReader(pua))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            string[] a = line.Split('|');
                            if (!ls.Exists(t => t.work.Contains(a[0])))
                            {
                                ls.Add(new Test() { work = a[0], hot = a[1],ID= a[2],name=a[3] });
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }

        public static string post(string wordname)
        {
            Console.WriteLine("获取链接~");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://aweme.snssdk.com/aweme/v1/hot/search/video/list/?hotword=" + wordname;
            hi.Allowautoredirect = true;
            hi.Accept = "application/json; charset=utf-8";
            hi.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36";
            return hh.GetHtml(hi);

        }

        public static Ggs josnruku(string josns, string wordnames)
        {
            SufeiNet_Test2 rb = JsonConvert.DeserializeObject<SufeiNet_Test2>(josns);
            if (rb.aweme_list.Count != 0)
            {
                Ggs t2 = zhengli1(rb.aweme_list[0]);
                if (t2 != null)
                {
                    return t2;
                }
                else
                {
                    Console.WriteLine(wordnames + ":采集失败");
                    return null;
                }
            }
            else
            {
                Console.WriteLine(wordnames + ":没关键字");
                return null;
            }
        }

        public static Ggs zhengli1(AwemeList al)
        {
            Ggs t1 = new Ggs();
            if (al.video != null)
            {
                if (al.video.bit_rate.Count != 0)
                {
                    if (al.video.bit_rate[0].play_addr != null)
                    {
                        if (al.video.bit_rate[0].play_addr.url_list.Count != 0)
                        {
                            t1.url = al.video.bit_rate[0].play_addr.url_list[0];
                        }
                    }
                }
            }
            if (al.desc != null)
            {
                t1.name = nametxt(al.desc);
            }
            if (al.aweme_id != null)
            {
                t1.ID = al.aweme_id;
            }

            if (t1.ID != null && t1.name != null && t1.url != null)
            {
                return t1;
            }
            else
            {
                return null;
            }
        }

        public static string nametxt(string txt)
        {
            Regex zhonwen = new Regex(@"[\u4e00-\u9fa5]");
            Regex da = new Regex(@"[\u0041-\u007a]");
            Regex shu = new Regex(@"[\u0030-\u0039]");
            string acd = "";
            foreach (var item in txt)
            {
                if (item == 32)
                {
                    acd += item;
                }
                else
                if (item == 35)
                {
                    acd += item;
                }
                else
                if (zhonwen.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                if (da.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                if (shu.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                {
                    acd += " ";
                }


            }
            return acd;

        }

        public static void post2(string name,string url)
        {
            Console.WriteLine("ye指令");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://eob4vzrz7a48fik.m.pipedream.net";
            hi.Method = "post";
            hi.Postdata = "name="+ name;
            hi.Cookie = url;
            hi.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            hh.GetHtml(hi);

        }

        public static void go(List<Test> ls)
        {
            
            int s = 0;
            Console.WriteLine(ls.Count);
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].ID == "")
                {
                    Console.WriteLine("进入");
                    string posttxt = post(ls[i].work);
                    if (posttxt == "string error")
                    {
                        continue;
                    }
                    Ggs tc = josnruku(posttxt, ls[i].work);
                    Console.WriteLine("post");
                    if (tc != null)
                    {
                        post2(tc.name, tc.url);
                        ls[i].ID = tc.ID;
                        ls[i].name = tc.name;
                        break;
                    }
                    else
                    {
                        ls[i].ID = "0";
                        ls[i].name = "无视频";
                    }
                }
            }       
        }
    }
    public class Test

    {

        public string work { get; set; }

        public string hot { get; set; }

        public string ID { get; set; }

        public string name { get; set; }

    }
    public class Ggs

    {
        public string url { get; set; }

        public string ID { get; set; }

        public string name { get; set; }

    }


}
