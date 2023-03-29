using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DestructorStaticOverloading
{
    class CountNumber
    {
        public static int number = 0; // trường dữ liệu number là một biến dùng chung cho các đối tượng không chỉ riêng của đối tượng this
        public static void Infor()    // phương thức Infor cũng là một hàm dùng chung cho các đối tượng
        {
            Console.WriteLine("So lan truy cap "+ number);
        }
        public void Count()
        {
            number++; // ở đây không thể gọi this.number
        }
    }
    class student
    {
        public readonly string name; // trường dữ liệu chỉ đọc có thể gán luôn khi khởi tạo hoặc khởi tạo bằng hàm khởi tạo
        public student(string name)
        {
            this.name = name;
        }
    }

    class Vector
    {
        public double x;
        public double y;
        public Vector(double x = 0, double y = 0)
        {
            this.x = x;
            this.y = y;
        }
        public void Infor()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }
        // over loading
        public static Vector operator + (Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //CountNumber.Infor();
            //Console.WriteLine(CountNumber.number);
            //CountNumber c1 = new CountNumber(); 
            //CountNumber c2 = new CountNumber();

            //c1.Count();
            //c2.Count();
            //c1.Count();
            //CountNumber.Infor();

            //student s = new student("Nguyen Ngoc Phuong");
            //Console.WriteLine(s.name);

            Vector a = new Vector(1, 2);
            Vector b = new Vector(2, 3);

            Vector c = new Vector();

            c = a+ b;
            c.Infor();
        }
    }
}
