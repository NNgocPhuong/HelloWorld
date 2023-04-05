using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ReviewDelegate;

namespace ReviewDelegate
{
    internal class Program
    {
        //public Action<int> action;
        public static void tinhTong()
        {
            TestAction(4, 5, (x) =>
                Console.WriteLine($"Tong hai so la: {x}"));
        }
        
        static void Main(string[] args)
        {

            //c = TestFunc.Sum(a, b);
            UseFunc();
            tinhTong();
            Console.ReadLine();
            
        }
        public static void UseFunc()
        {
            TestFunc a = new TestFunc(3, 2);
            TestFunc b = new TestFunc(1, 2);
            
            Func<TestFunc, TestFunc, TestFunc> func;
            func = TestFunc.Sum;
            var c = func(a, b);
            c.Show();
        }
        public static void TestAction(int a, int b , Action<string> callBack)
        {
            int c = a + b;
            callBack(c.ToString());
        }
        
    }
}
