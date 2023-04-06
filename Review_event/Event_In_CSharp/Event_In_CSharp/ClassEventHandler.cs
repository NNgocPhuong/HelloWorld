using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewEvent
{
    public class Event_Args : EventArgs
    {
        public string data
        { get; set; }
        public Event_Args(string _data)
        {
            data = _data;
        }
    }
    internal class Publisher
    {
        event EventHandler<Event_Args> ClassEvent;
        public event EventHandler<Event_Args> clEvent
        {
            add { ClassEvent += value; }
            remove { ClassEvent -= value; }
        }
        public string Name
        {
            get; set;
        }
        public void Chao_hoi()
        {
            ClassEvent?.Invoke(this, new Event_Args(Name));
        }
    }
    internal class SubsriberA
    {
        private void Chao_hoi_kieuA(object sender, Event_Args e)
        {
            Console.WriteLine(", rat vui duoc gap anh " + e.data);
        }
        public void sub(Publisher publisher)
        {
            publisher.clEvent += Chao_hoi_kieuA;
        }
    }
    internal class SubsriberB
    {
        private void Chao_hoi_kieuB(object sender, Event_Args e)
        {
            Console.WriteLine(", nice to meet you " + e.data);
        }
        public void sub(Publisher publisher)
        {
            publisher.clEvent += Chao_hoi_kieuB;
        }

    }
}
