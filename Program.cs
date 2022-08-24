using System;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (StreamWriter sw = new StreamWriter("README.md", true))
            {
                sw.WriteLine("\r\n" + DateTime.Now.ToString("HH:mm:ss") + "\r\n");
            }
        }
    }
}
