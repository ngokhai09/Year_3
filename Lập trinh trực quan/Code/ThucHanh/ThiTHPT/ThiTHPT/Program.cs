using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTHPT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TuyenSinh> listTS = new List<TuyenSinh>();
           
            Console.WriteLine("Nhap so thi sinh: ");
            int n = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                TuyenSinh TS = new TuyenSinh();
                Console.WriteLine("Nhap thi sinh thu {0}: ", i);
                TS.Nhap();                
                listTS.Add(TS);
                
            }
            Console.WriteLine("Nhap diem chuan: ");
            double diem = Double.Parse(Console.ReadLine());
            Console.WriteLine("Danh sach thi sinh trung tuyen: ");
            foreach(TuyenSinh item in listTS)
            {
                if (item.Tong() >= diem)
                {
                    item.Xuat();
                    Console.WriteLine("---------------");
                }
            }
            Console.ReadLine();
        }
    }
}
