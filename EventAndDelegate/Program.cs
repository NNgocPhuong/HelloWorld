using System.Runtime.ConstrainedExecution;

namespace CsEvent
{
    /*
     *  publisher - class : Phát sự kiện 
     *  subscriber - class : nhận sự kiện 
     */
    //public delegate void suKienNhapSo(int x);

    class DuLieuNhap : EventArgs
    {
        public int data { set; get; }
        public DuLieuNhap(int x)
        {
            data = x;
        }
    }
    class UserInput
    {
        //public event suKienNhapSo su_kien_nhap_so;
        public event EventHandler su_kien_nhap_so;
        // ~ delegate void Kieu(object sender, EventArgs args)
        public void Input()
        {

            Console.Write("Nhap vao so nguyen: ");
            int i = Int32.Parse(Console.ReadLine());
            su_kien_nhap_so?.Invoke(this, new DuLieuNhap(i));

        }
    }
    // tính căn...
    // ~ delegate void Kieu(object sender, EventArgs args)
    class TinhCan
    {
        public void Sub(UserInput input)
        {
            input.su_kien_nhap_so += Can;
        }
        public void Can(object sender, EventArgs e)
        {
            DuLieuNhap duLieuNhap = (DuLieuNhap)e;
            int a = duLieuNhap.data;
            Console.WriteLine($"can ban 2 cua so {a} la: {Math.Sqrt(a)}");

        }
    }
    class BinhPhuong
    {
        public void Sub(UserInput input)
        {
            input.su_kien_nhap_so += binh_phuong;
        }
        public void binh_phuong(object sender, EventArgs e)
        {
            DuLieuNhap duLieu = (DuLieuNhap)e;
            int a = duLieu.data;
            Console.WriteLine($"Binh phuong cua so {a} la: {a * a}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UserInput user_input = new UserInput();

            user_input.su_kien_nhap_so += (sender, e) =>
            {
                DuLieuNhap duLieuNhap = (DuLieuNhap)e;
                Console.WriteLine("Ban vua nhap so: " + duLieuNhap.data);
            };

            TinhCan tinhCan = new TinhCan();
            tinhCan.Sub(user_input);

            BinhPhuong bin = new BinhPhuong();
            bin.Sub(user_input);

            user_input.Input();
        }
    }

}