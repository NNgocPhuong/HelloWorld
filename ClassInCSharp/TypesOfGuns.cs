using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInCSharp
{
    internal class TypesOfGuns
    {
        private string name;
        private int damage_level;
        public int damage
        {
            get
            {
                return damage_level;
            }
            set
            {
                damage_level = value;
            }
        }
        public TypesOfGuns()
        {
            name= string.Empty;
            damage_level = 0;
        }

        public TypesOfGuns(string name, int damage_level)
        {
            this.name = name;
            this.damage_level = damage_level;
        }

        public void Attack()
        {
            Console.Write(name + ":\t ");
            for (int i = 0; i < damage_level; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        public void thietLapSucTanCong(int value)
        {
            damage = value;
        }

    }
}
