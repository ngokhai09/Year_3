using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Program
    {
        class Ex1
        {
            public Ex1()
            {
                Ex1_Quan_Ly_Sinh_Vien qlsv = new Ex1_Quan_Ly_Sinh_Vien();
                qlsv.Input();
                qlsv.Print();
                qlsv.Count_KhoaLuan();
                qlsv.Count_LuanVan();
                Console.WriteLine("So luong sinh vien lam chuyen de tot nghiep la: " + qlsv.Cnt1);
                Console.WriteLine("So luong sinh vien lam khoa luan tot nghiep la: " + qlsv.Cnt2);
                Console.ReadLine();
            }
            
        }
        class Ex2
        {
            public Ex2()
            {
                Ex2_Phan_So ps = new Ex2_Phan_So();
                Ex2_Phan_So ps1 = new Ex2_Phan_So();
                Ex2_Phan_So ps2 = new Ex2_Phan_So();
                ps1.Input();
                ps2.Input();
                ps = ps1 + ps2;
                ps.Print();
                Console.ReadLine();
            }
        }
        class Ex3
        {
            public Ex3()
            {
                Ex3_Diem_Toa_Do p1 = new Ex3_Diem_Toa_Do();
                Ex3_Diem_Toa_Do p2 = new Ex3_Diem_Toa_Do();
                p1.Input();
                p2.Input();
                Console.WriteLine("Toa do giua 2 diem la: " + p1.Distance(p2));
                Console.ReadLine();
            }
        }
        class Ex4
        {
            public Ex4()
            {
                Ex4_Mang ex = new Ex4_Mang();
                ex.Input();
                ex.Print();
                Console.Read();
            }
        }
        class Ex5
        {
            public Ex5()
            {
                Ex5_Matrix matrix = new Ex5_Matrix();
                matrix.Input();
                matrix.ChuyenVi();
                Console.Read();
            }
        }
        class Ex6
        {
            public Ex6()
            {

            }
        }
        class Ex7
        {
            public Ex7()
            {

            }
        }
        static void Main(string[] args)
        {
            Ex3 ex = new Ex3();
        }
    }
}
