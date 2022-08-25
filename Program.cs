
using DotNet.Utilities;
using Newtonsoft.Json;
using SufeiNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            var url = "http://v26-web.douyinvod.com/f2d20617bd7701d267a80c7253caee8d/6307312d/video/tos/cn/tos-cn-ve-15c001-alinc2/5735e3e23bd143968f261c71147e7c5b/?a=6383&ch=50&cr=0&dr=0&lr=all&cd=0%7C0%7C0%7C0&cv=1&br=755&bt=755&cs=0&ds=4&ft=t2zLrtjjM95MxrKqBZmCTeK_ScoAps1N2CvrKx~F9~to0&mime_type=video_mp4&qs=0&rc=NjppZDc3aDRnOWRkaTk5ZEBpM3FxamQ6Znc0ZjMzNGkzM0A0MmIxM2A2XmAxM2BeLWFgYSMvbGJscjRnaC5gLS1kLS9zcw%3D%3D&l=2022082515215601013516823204011DBD";
            var save = @"11.mp4";
            using (var web = new WebClient())
            {
                web.DownloadFile(url, save);
            }

            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic = filedouyin();
            //dic = postdouyin(dic);
            //paixu(dic);
            //using (StreamWriter sw = new StreamWriter(pua, false))
            //{
            //    foreach (var item in dic)
            //    {
            //        sw.WriteLine(item.Key + "|" + item.Value + "\r\n");
            //    }

            //}
        }

        public static string pua = @"acc/" + DateTime.Now.ToString("yyyyMMdd") + ".md";


        public static Dictionary<string, string> postdouyin(Dictionary<string, string> dicd)
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
                            if (!dicd.ContainsKey(item.Word))
                            {
                                dicd.Add(item.Word, item.HotValue);
                                Console.WriteLine("关键字：" + item.Word + "  ----  热度：" + item.HotValue);
                            }
                            else
                            {
                                dicd[item.Word] = item.HotValue;
                            }
                        }
                    }
                }
            }
            return dicd;
        }

        public static void paixu(Dictionary<string, string> d1)
        {

            Dictionary<string, int> d2 = new Dictionary<string, int>();
            foreach (var item in d1)
            {
                d2.Add(item.Key, int.Parse(item.Value));
            }

            if (d2.Count > 0)
            {
                List<KeyValuePair<string, int>> lst = new List<KeyValuePair<string, int>>(d2);
                lst.Sort(delegate (KeyValuePair<string, int> s1, KeyValuePair<string, int> s2)
                {
                    return s2.Value.CompareTo(s1.Value);
                });
                d1.Clear();
                foreach (KeyValuePair<string, int> kvp in lst)
                    d1.Add(kvp.Key, kvp.Value.ToString());

            }
        }

        public static Dictionary<string, string> filedouyin()
        {
            Dictionary<string, string> dicc = new Dictionary<string, string>();
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
                            if (!dicc.ContainsKey(a[0]))
                            {
                                dicc.Add(a[0], a[1]);
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            return dicc;
        }
    }
}
