using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypesOfGuns guns1 = new TypesOfGuns("pistol", 1);
            TypesOfGuns guns2 = new TypesOfGuns("rifle", 3);
            TypesOfGuns guns3 = new TypesOfGuns("shotGuns", 5);
            
            guns1.damage = 10;

            Console.WriteLine(guns1.damage);
            guns1.thietLapSucTanCong(2);
            guns1.Attack();
            guns2.Attack();
            guns3.Attack();
           
            Console.ReadKey();
        }
    }
}
