using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTHPT
{
    class TuyenSinh : ThiSinh
    {
        private int KV;
        public void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap Khu Vuc: ");
            KV = Int16.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Khu Vuc: {0}", KV);
        }
        public double Tong()
        {
            double s =  KV == 1 ? 0.0 : (KV == 2 ? 1.0 : 2.0);
            s += base.Tong();
            return  s;
        }
    }
}
