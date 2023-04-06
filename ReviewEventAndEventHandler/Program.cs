using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEventHandler;

namespace ReviewEventAndEventHandler
{
    internal class Program
    {

        static void Main(string[] args)
        {
            publisher p = new publisher();
            subsriberA sa = new subsriberA();
            SubscriberB sb = new SubscriberB();

            sa.Sub(p);
            sb.Sub(p);
            p.send();
            Console.ReadKey();
        }
    }
}
