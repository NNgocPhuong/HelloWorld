using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

// Func<kieuBien1, kieuBien2,..., kieuTraVe> ten;
namespace ReviewDelegate
{
    internal class TestFunc
    {
        public int tu_so;
        public int TuSo
        {
            get { return tu_so; }
            set { tu_so = value; }
        }
        public int mau_so;
        public int MauSo
        {
            set { mau_so = value; }
            get { return mau_so; }
        }
        public TestFunc(int tu = 0, int mau = 0)
        {
            this.tu_so = tu;
            this.mau_so = mau;
        }
        public static TestFunc operator + (TestFunc a, TestFunc b)
        {
            TestFunc testFunc = new TestFunc();
            testFunc.tu_so = a.tu_so * b.mau_so + b.tu_so * a.mau_so;
            testFunc.mau_so = a.mau_so * b.mau_so;
            return testFunc;
        }
        public static TestFunc Sum(TestFunc a, TestFunc b)
        {
            return a + b;
        }
        public void Show()
        {
            Console.WriteLine($"Tu so = {this.tu_so}, Mau so = {this.mau_so}");
        }
    }
}
