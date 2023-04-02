using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_List
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Origin { get; set; }
        public int ID { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 3, 6, 3, 1, 8, 1, 0, 9 };

            // Mot so phuong thuc hay dung
            //list.Add(9);
            //list.Insert(0, 10);
            //list.RemoveAt(2);
            //list.Remove(1);
            //list.Remove(3);
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            // tim kiem trong list:
            //var n = list.FindAll(
            //    (x) =>
            //    {
            //        return x % 2 == 0;
            //    }
            //    );

            //foreach ( var x in n )
            //{
            //    Console.WriteLine( x );
            //}

            List<Product> product = new List<Product>()
            {
                new Product() {
                Name = "Iphone", Price = 1000, ID = 1, Origin =  "China"
                },
                new Product() {
                Name = "Samsung", Price = 900, ID = 2, Origin =  "Korea"
                },
                new Product() {
                Name = "Vsmart", Price = 1100, ID = 3, Origin =  "VietNam"
                },
                new Product() {
                Name = "Xiaomi", Price = 800, ID = 4, Origin =  "China"
                }
            };
            //var p = product.FindAll(
            //    (x) =>
            //    {
            //        return x.Origin == "China";
            //    }
            //    );
            //foreach( var x in p )
            //{
            //    Console.WriteLine(x.Name + ' ' + x.Price + ' ' + x.Origin);
            //}
            product.Sort(
                (a, b) =>
                {
                    if (a.Price == b.Price) return 0;
                    if (a.Price < b.Price) return -1;
                    return 1;
                }
                );
            foreach (var item in product)
            {
                Console.WriteLine(item.Name + ' ' + item.Price + ' ' + item.Origin);
            }
        }
    }
}
