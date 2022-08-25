
using DotNet.Utilities;
using Newtonsoft.Json;
using SufeiNet;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic = filedouyin();
            dic = postdouyin();
            using (StreamWriter sw = new StreamWriter(pua, true))
            {
                foreach (var item in dic)
                {
                    sw.WriteLine(item.Key + "|" + item.Value + "\r\n");
                }

            }
        }

        public static string pua = @"acc/" + DateTime.Now.ToString("yyyyMMdd") + ".md";


        public static Dictionary<string, string> postdouyin()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
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
                            if (!dic.ContainsKey(item.Word))
                            {
                                dic.Add(item.Word, item.HotValue);
                                Console.WriteLine("关键字：" + item.Word + "  ----  热度：" + item.HotValue);
                            }
                        }
                    }
                }
            }
            return dic;
        }

        public static void ce()
        {
            Console.WriteLine(DateTime.Now.ToString("yyyyMMdd"));

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
                        string[] a = line.Split('|');
                        if (!dicc.ContainsKey(a[0]))
                        {
                            dicc.Add(a[0], a[1]);
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            return dicc;
        }
    }
}
