using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS
{
    class phs
    {
        private int tu, mau;
        public phs()
        {
            this.tu = 0;
            this.mau = 1;
        }
        public phs(int tu,int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }
        public void nhap()
        {
            Console.Write("nhap tu so: ");
            int ts = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            int ms = Convert.ToInt32(Console.ReadLine());
            while (ms == 0)
            {
                Console.WriteLine("Mau so khong the bang 0");
                Console.Write("Moi nhap lai mau so: ");
                ms = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void In()
        {
            Rutgon();
            Console.WriteLine("{0}/{1}", this.tu, this.mau);
        }
        public int UCLN(int x, int y)
        {
            if(y == 0) return x;
	    return UCLN(y, x%y);
        }
        public phs Rutgon()
        {            
            k = UCLN(this.tu, this.mau);
            return new phs(this.tu / k, this.mau / k);
        }
        public static phs operator+(phs a,phs b)
        {
            return new phs(a.tu * b.mau + a.mau * b.tu, a.mau * b.mau).Rutgon();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            phs a = new phs();
            phs b = new phs();
            phs c = new phs();
            a.nhap();
            b.nhap();
            a.In();
            b.In();
            Console.Write("Tong cua 2 phan so:");
            c = a + b;
            c.In();
          /*  Console.Write("Hieu cua 2 phan so:");
            c = a - b;
            c.In();
            Console.Write("Tich cua 2 phan so:");
            c = a * b;
            c.In();
            Console.Write("Thuong cua 2 phan so:");
            c = a / b;
            c.In();*/
        }
    }
}
