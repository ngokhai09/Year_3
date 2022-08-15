using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Ex2_Phan_So
    {
        private int Tu;
        private int Mau;
        public Ex2_Phan_So()
        {
            Tu = 0;
            Mau = 1;
        }
        public Ex2_Phan_So(int Tu, int Mau)
        {
            this.Tu = Tu;
            this.Mau = Mau;
        }
        public void Input()
        {
            Console.Write("Nhap phan so theo dang a/b: ");
            string a = Console.ReadLine();
            string[] t = a.Split('/');
            Tu = Int16.Parse(t[0]);
            Mau = Int16.Parse(t[1]);
        }
        public void Print()
        {
            Console.Write("Phan so: " + Tu);
            if (Mau != 1)
                Console.Write("/" + Mau);
        }
        public int UCLN(int a, int b)
        {
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
        public void RutGon()
        {
            int t = UCLN(Tu, Mau);
            Tu /= t;
            Mau /= t;
        }
        public static Ex2_Phan_So operator +(Ex2_Phan_So a, Ex2_Phan_So b)
        {
            Ex2_Phan_So z = new Ex2_Phan_So();
            z.Tu = a.Tu * b.Mau + a.Mau * b.Tu;
            z.Mau = a.Mau * b.Mau;
            z.RutGon();
            return new Ex2_Phan_So(z.Tu, z.Mau);
        }
        public static Ex2_Phan_So operator -(Ex2_Phan_So a, Ex2_Phan_So b)
        {
            Ex2_Phan_So z = new Ex2_Phan_So();
            z.Tu = a.Tu * b.Mau - a.Mau * b.Tu;
            z.Mau = a.Mau * b.Mau;
            z.RutGon();
            return new Ex2_Phan_So(z.Tu, z.Mau);
        }
        public static Ex2_Phan_So operator *(Ex2_Phan_So a, Ex2_Phan_So b)
        {
            Ex2_Phan_So z = new Ex2_Phan_So();
            z.Tu = a.Tu * b.Tu;
            z.Mau = a.Mau * b.Mau;
            z.RutGon();
            return new Ex2_Phan_So(z.Tu, z.Mau);
        }
        public static Ex2_Phan_So operator /(Ex2_Phan_So a, Ex2_Phan_So b)
        {
            Ex2_Phan_So z = new Ex2_Phan_So();
            z.Tu = a.Tu * b.Mau;
            z.Mau = a.Mau * b.Tu;
            z.RutGon();
            return new Ex2_Phan_So(z.Tu, z.Mau);
        }
    }
}
