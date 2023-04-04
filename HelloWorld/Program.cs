using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Programb
    {
        enum a { mon = 2, tue, web, thus, fri, sat, sun };

        static void Main(string[] args)
        {
            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "Nguyen Ngoc Phuong");
            //dic.Add(2, "Nguyen Van A");
            //dic.Add(3, "Nguyen Van B");
            //dic.Add(4, "Nguyen Van C");
            //int i = 0;
            //foreach(var key in dic)
            //{
            //    Console.WriteLine(key);
            //    Console.WriteLine("key = {0}, Value = {1}, {2}", key.Key, key.Value,i);
            //    i++;
            //}
            XinChao.Class1.Chao();
            

            
            Console.WriteLine(Convert.ToInt32(a.fri));
            
            Console.ReadKey();
        }
    }
}
