using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInCsharp
{
    internal class Program
    {
        public delegate void showLog(string message);
        static void info(string message)
        {
            Console.WriteLine(message);
        }
        static void error(int a, string message) 
        {
            if(a == 0) { Console.WriteLine(message); }
            else { Console.WriteLine("Not " + message); }
        }

        static int Tong(int a, int b)
        {
            return a + b;
        }

        static void Hieu(int a,int b, showLog log)
        {
            int kq = a - b;
            log?.Invoke($"Hieu la {kq}");
        }
        static void Main(string[] args)
        {
            showLog show = null;
            show = info;
            show.Invoke("Nguyen Ngoc Phuong");
            Action<int, string> action = null; //~ delegate void action(int, string)
            action = error;
            action(1, "Facebook");

            //Func<int> func = null;  //~ delegate int Kieu();
            //Func<string, double, string> func2 = null;  // ~ delegate string Kieu(string, double)
            Func<int, int, int> func = Tong;
            Console.WriteLine(func(5, 10));

            Hieu(4, 5, info);

        }
    }
}
