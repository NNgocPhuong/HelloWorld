using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_LINQ
{
    public class Product
    {
        public int ID { set; get; }
        public string Name { set; get; }         // tên
        public double Price { set; get; }        // giá
        public string[] Colors { set; get; }     // các màu sắc
        public int Brand { set; get; }           // ID Nhãn hiệu, hãng
        public Product(int id, string name, double price, string[] colors, int brand)
        {
            ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
        }
        // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
        override public string ToString()
           => $"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";

    }
    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p = new Product(1, "Abc", 1000, new string[] { "xanh", "do" }, 2);
            //Console.WriteLine(p);


            var brands = new List<Brand>()
            {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            //var query = from p in products
            //            where p.Price == 400
            //            select p;

            //foreach(var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            // in ra ten san pham, ten thuong hieu, co gia (300-400)
            // gia giam dan

            products.Where(p => p.Price >= 300 && p.Price <= 400)
                .OrderByDescending(p => p.Price)
                .Join(brands, p => p.Brand, b => b.ID, (sp, th) =>
                {
                    return new
                    {
                        tenSP = sp.Name,
                        tenTH = th.Name,
                        gia = sp.Price,
                    };
                })
                .ToList().ForEach(infor =>
                Console.WriteLine($"{infor.tenSP,15} {infor.tenTH,15} {infor.gia,5}"));



            Console.ReadLine();
        }
    }
}
