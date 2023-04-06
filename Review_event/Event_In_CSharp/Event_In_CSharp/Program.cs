using ReviewEvent;
using System;

namespace Program
{
    internal class _Program
    {
        public void Main(string[] args)
        {
            test();
            Console.ReadKey();
        }
        public static void test()
        {
            Publisher publisher = new Publisher();
            SubsriberA subsriberA = new SubsriberA();
            SubsriberB subsriberB = new SubsriberB();
            publisher.Name = "Nguyen Ngoc Phuong";
            subsriberA.sub(publisher);
            subsriberB.sub(publisher);
        }
    }
}