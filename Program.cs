
using DotNet.Utilities;
using Newtonsoft.Json;
using SufeiNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp8
{
    class Program
    {


        public static urlx uu = new urlx();

        public static List<string> lstxt = new List<string>();
        public static List<string> lswork = new List<string>();

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                log("无密码");
                return;
            }
            else
            {
                string[] aa = args[0].Split('|');
                if (aa.Length == 3)
                {
                    uu.url1 = aa[0];
                    uu.url2 = aa[1];
                    uu.url3 = aa[2];
                    log("正确开始运行");
                }
                else
                {
                    log("密码错误");
                    return;
                }
            }
            douyin();
        }


        public static void douyin()
        {
            List<Test> ls = new List<Test>();

            filedouyin(ls, lstxt, lswork);
            postdouyin(ls, uu.url1);
            ls = paixu(ls);
            go(ls);
            xietxt(ls);
        }

        public static string pua = @"acc/" + DateTime.Now.ToString("yyyyMMdd") + ".md";

        public static string txt = @"acc/txt.md";

        public static string work = @"acc/work.md";

        public static void log(string text)
        {
            Console.WriteLine(text);
        }

        public static void postdouyin(List<Test> ls,string url)
        {
            log("获取热点");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = url;
            hi.IsToLower = false;
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
                                log("获取新热点：  "+ item.Word+"------"+"热度："+ item.HotValue);
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
            log("热度排序成功！");
            ls = ls.OrderByDescending(o => o.hot.Length).ThenByDescending(o => o.hot).ToList();
            return ls;
        }

        public static void filedouyin(List<Test> ls, List<string> lstxt, List<string> lswork)
        {
            log("加载信息");
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
                using (StreamReader sr = new StreamReader(pua, Encoding.Default))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            string[] a = line.Split('|');
                            if (!ls.Exists(t => t.work.Contains(a[0])))
                            {
                                ls.Add(new Test() { work = a[0], hot = a[1],ID= a[2] });
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
                using (StreamReader sr = new StreamReader(txt))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            lstxt.Add(line);
                        }
                        line = sr.ReadLine();
                    }
                }
                using (StreamReader sr = new StreamReader(work, Encoding.Default))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            lswork.Add(line);
                        }
                        line = sr.ReadLine();
                    }
                }
            }
        }

        public static string post(string wordname, string url)
        {
            log("获取链接~");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = url + wordname;
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

        public static string post2(string namec, string urlc, string workc, string uurl)
        {
            Console.WriteLine("ye指令");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = uurl;
            hi.Method = "post";
            hi.Postdata = "{\"name\":\"" + namec + "\",\"url\":\"" + urlc + "\",\"work\":\"" + workc + "\" }";
            hi.ContentType = "application/json";
            return hh.GetHtml(hi);

        }

        public static void go(List<Test> ls)
        {
            log("当前热点 "+ ls.Count+" 条记录");
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].ID == ""|| ls[i].ID ==null)
                {
                    log("获取URL： " + ls[i].ID);
                    string posttxt = post(ls[i].work,uu.url2);
                    if (posttxt == "string error")
                    {
                        log("post失败");
                        continue;
                    }
                    Ggs tc = josnruku(posttxt, ls[i].work);
                    if (tc != null)
                    {
                       
                        if (pan(tc.ID, tc.name))
                        {
                            log("获取URL 成功");
                            if (post2(tc.name, tc.url, ls[i].work, uu.url3).Contains("success"))
                            {
                                log(tc.ID + "----" + tc.name+"           发布成功！");
                            }
                            
                            ls[i].ID = "1";
                            xieid(tc.ID);
                            break;
                        }
                        else
                        {
                            ls[i].ID = "0";
                            log("ID已发布");
                        }

                    }
                    else
                    {
                        ls[i].ID = "0";
                    }
                }
                else
                {
                    log("ID不合法 抛弃");
                }
            }       
        }

        public static bool pan(string xx,string dx)
        {
            if (lstxt.Contains(xx))
            {
                return false;
            }
            foreach (var item in lswork)
            {
                if (dx.Contains(item))
                {
                    return false;
                }
            }
            return true;

        }

        public static void xieid(string idd)
        {
            using (StreamWriter sw = new StreamWriter(txt, true, Encoding.Default))
            {
                sw.WriteLine(idd + Environment.NewLine);
            }
        }

        public static void xietxt(List<Test> lss)
        {
            using (StreamWriter sw = new StreamWriter(pua, false, Encoding.Default))
            {
                foreach (var item in lss)
                {
                    string txtl = item.work + "|" + item.hot + "|" + item.ID + Environment.NewLine;
                    sw.WriteLine(txtl);
                }

            }
        }
    }
    public class Test

    {

        public string work { get; set; }

        public string hot { get; set; }

        public string ID { get; set; }


    }
    public class Ggs

    {
        public string url { get; set; }

        public string ID { get; set; }

        public string name { get; set; }

    }

    public class urlx
    {
        public string url1 { get; set; }
        public string url2 { get; set; }
        public string url3 { get; set; }
    }


}
