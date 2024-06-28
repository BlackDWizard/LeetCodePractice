using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Drawing;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InsertImage();
            //LoadAndSaveImage("0000000001");
            double s = 700000 - 205260;
            double sum = 0;
            for (int i = 1; i < 5; i++)
            {
                sum += s;
                Console.WriteLine("s:" + s);
                Console.WriteLine("sum:" + (sum + 650000));
                s = s * Math.Pow(1.11, i);
            }
            Console.ReadKey();  //可按任意鍵結束畫面
        }
    }
}
