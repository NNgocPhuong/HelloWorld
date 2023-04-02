using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            string s = Console.ReadLine();
            b = int.Parse(s);

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch 
            {
                Console.WriteLine("Loi khi thuc hien phep chia");
            }
            Console.WriteLine("Phuong dep trai");
        }
    }
}
