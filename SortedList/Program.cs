using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SortedList<TKey, TValue>
namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> TenTuoi = new SortedList<string, int>()
            {
                { "Nam",13}, {"Ngoc", 21}, {"Thinh", 21}
            };
            TenTuoi.Add("Phuong", 21);
            TenTuoi["Trung"] = 30;
            Console.WriteLine(TenTuoi.IndexOfKey("Phuong"));
            foreach (var keyValuePair in TenTuoi) { Console.WriteLine(keyValuePair.Key +'\t'+ keyValuePair.Value); }
            Console.ReadKey();
        }
    }
}
