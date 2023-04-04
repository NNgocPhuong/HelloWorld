using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dictionary<TKey, TValue> : Kha giong voi SortedList
// HashSet <T> : co che don gian nhat de luu gia tri, cung cap hieu nang cao cho cac tac vu tim, them, xoa, sua
namespace Dictionary_And_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs["Ha Noi"] = 1;
            keyValuePairs["TP Ho Chi Minh"] = 1;
            keyValuePairs["Da Nang"] = 1;
            keyValuePairs["Viet Tri"] = 2;
            keyValuePairs["Vinh Yen"] = 2;
            keyValuePairs["Hai Phong"] = 1;
            keyValuePairs["Tuyen Quang"] = 3;
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key + '\t' + item.Value);
            }

            HashSet<int> keys = new HashSet<int>();
            keys.Add(1);
            keys.Add(2);
            keys.Add(5);
            keys.Add(3);
            keys.Add(1);
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
