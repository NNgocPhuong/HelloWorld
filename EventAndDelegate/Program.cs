using System.Runtime.ConstrainedExecution;

namespace CsEvent
{
    /*
     *  publisher - class : Phát sự kiện 
     *  subscriber - class : nhận sự kiện 
     */
    public delegate void suKienNhapSo(int x);
    class UserInput
    {
        public suKienNhapSo su_kien_nhap_so { set; get; }
        public void Input()
        {
            do
            {
                Console.Write("Nhap vao so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                su_kien_nhap_so?.Invoke(i);
            }
            while (true);
        } 
    }

    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.su_kien_nhap_so = Can;
        }
        public void Can(int a)
        {
            Console.WriteLine($"can ban 2 cua so {a} la: {Math.Sqrt(a)}");

        }
    }
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.su_kien_nhap_so = binh_phuong;
        }
        public void binh_phuong(int a)
        {
            Console.WriteLine($"Binh phuong cua so {a} la: {a * a}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserInput user_input = new UserInput();
            
            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(user_input);

            BinhPhuong bin = new BinhPhuong();
            bin.Sub(user_input);
            user_input.Input();
        }
    }
}