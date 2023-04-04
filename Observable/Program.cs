using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ObservableCollection: xay dung tap hop co su giam sat bien dong thay doi phan tu
namespace ObservableCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> obs = new ObservableCollection<string>();

            obs.CollectionChanged += change;
            obs.Add("ZTest1");
            obs.Add("DTest2");
            obs.Add("ATest3");
            obs[2] = "AAAAA";

            obs.RemoveAt(1);
            obs.Clear();

            Console.ReadKey();
        }
        // Phương thức nhận sự kiện CollectionChanged
        private static void change(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (String s in e.NewItems)
                        Console.WriteLine($"Thêm :  {s}");
                    break;

                case NotifyCollectionChangedAction.Reset:
                    Console.WriteLine("Clear");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (String s in e.OldItems)
                        Console.WriteLine($"Remove :  {s}");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Repaced - " + e.NewItems[0]);
                    break;
            }
        }
    }

}
