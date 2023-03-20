using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    /*
     lambda - Anonymous function
    1, (tham so) => bieu_thuc;

    2, (tham so) => {
        cac bieu thuc;
        return bieu thuc tra ve;
    }
     
     */
    internal class Program
    {
        public delegate void ShowLog(string message); // cú pháp khai báo delegate
        static void Main(string[] args)
        {
            Action<string> action;
            action = (string s) => Console.WriteLine(s); // ~delegate void KIEU(string s) = Action<string>
            ShowLog show = (string s) => Console.WriteLine(s);
            show("Phuong Phu Tho");
            //(int a, int b) =>
            //{
            //    int kq = a + b;
            //    return kq;
            //}
            action?.Invoke("xin chao");

            Action thong_bao;
            thong_bao = () => Console.WriteLine("Phuong");

            thong_bao();

        }
    }
}
