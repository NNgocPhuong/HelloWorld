using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TestEventHandler
{
    public class myEventArgs : EventArgs
    {
        public myEventArgs(string data)
        {
            this.data = data;
        }
        private string data;
        public string Data
        {
            get { return this.data; }
        }
    }
    public class publisher
    {
        //public delegate void NotifyNews(object data);
        //public event NotifyNews event_News;
        public event EventHandler event_News;
        public void send()
        {
            event_News?.Invoke(this,new myEventArgs("Co tin moi"));
        }
    }
    public class subsriberA
    {
        public void Sub(publisher p)
        {
            p.event_News += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object sender, myEventArgs e)
        {
            myEventArgs a = (myEventArgs)e;
            Console.WriteLine("SubsriberA: "+ a.Data);
        }
    }
    public class SubscriberB
    {
        public void Sub(publisher p)
        {
            //p.event_News = null;  // Hủy các đối tượng khác nhận sự kiện
            p.event_News += ReceiverFromPublisher;
        }

        void ReceiverFromPublisher(object sender, myEventArgs e)
        {
            myEventArgs a = (myEventArgs)e;
            Console.WriteLine("SubscriberB: " + a.Data);
        }
    }

}
