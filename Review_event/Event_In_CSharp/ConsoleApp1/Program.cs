using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ReviewEvent;

namespace Program
{
    internal class _Program
    {
        public static void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            ReviewEvent.Publisher publisher = new ReviewEvent.Publisher();
            SubsriberA subsriberA = new SubsriberA();
            SubsriberB subsriberB = new SubsriberB();
            publisher.Name = "Nguyen Ngoc Phuong";
            subsriberA.sub(publisher);
            subsriberB.sub(publisher);
        }
    }
}