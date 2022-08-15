using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTHPT
{
    class ThiSinh
    {
        private int SBD;
        private string HoTen;
        private double m1;
        private double m2;
        private double m3;
        private double TongDiem;
        public ThiSinh() { }
        public ThiSinh(int SBD, string HoTen, double m1, double m2, double m3)
        {
            this.SBD = SBD;
            this.HoTen = HoTen;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhap so bao danh: ");
            SBD = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap diem m1: ");
            m1 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem m2: ");
            m2 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap diem m3: ");
            m3 = Double.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("So bao danh: {0}", SBD);
            Console.WriteLine("Ho ten: {0}", HoTen);
            Console.WriteLine("Diem m1: {0}", m1);
            Console.WriteLine("Diem m2: {0}", m2);
            Console.WriteLine("Diem m3: {0}", m3);
        }

        public double Tong()
        {
            return (m1 + m2 + m3);
        }

    }
}
