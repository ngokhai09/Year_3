using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class SinhVien
    {
        private string Name;
        private string Birth;
        private double[] Mark = new double[3];
        private double Arg;
        public SinhVien()
        {
            Name = Console.ReadLine();
            Birth = Console.ReadLine();
            Arg = 0;
            for (int i = 0; i < 3; i++)
            {
                Mark[i] = Double.Parse(Console.ReadLine());
                Arg += Mark[i];
            }
            Arg /= 3;
        }
        public void Print()
        {
            Console.WriteLine("Ten sinh vien: " + this.Name);
            Console.WriteLine("Nam Sinh: " + this.Birth);
            Console.WriteLine("Diem mon Lap trinh: " + this.Mark[0]);
            Console.WriteLine("Diem mon Co so du lieu: " + this.Mark[1]);
            Console.WriteLine("Diem mon Thiet ke web: " + this.Mark[2]);
            Console.WriteLine("Diem trung binh: " + this.Arg);
        }
        public bool checkUnder5()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Mark[i] < 5)
                {
                    return false;
                }
            }
            return true;
        }
        public bool checkArg()
        {
            if (Arg < 8)
            {
                return false;
            }
            return true;
        }
    };
    class Ex1_Quan_Ly_Sinh_Vien
    {
        private int n;
        private int cnt1 = 0;
        private int cnt2 = 0;
        private List<SinhVien> list_of_SinhVien = new List<SinhVien>();
        public void Input()
        {
            Console.Write("Nhap vao so sinh vien: ");
            n = Int16.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){
                SinhVien t = new SinhVien();
                list_of_SinhVien.Add(t);
            }
        }
        public void Print()
        {
            foreach(SinhVien item in list_of_SinhVien)
            {
                Console.WriteLine("---------------------------");
                item.Print();
            }
        }
        
        public void Count_LuanVan()
        {
            foreach(SinhVien item in list_of_SinhVien)
            {
                if (item.checkUnder5() == true){
                   cnt1++;
                }
            }
            
        }
        public void Count_KhoaLuan()
        {
            foreach (SinhVien item in list_of_SinhVien)
            {
                if (item.checkArg() == true && item.checkUnder5() == true)
                {
                    cnt2++;
                }
            }
        }
        public int Cnt1
        {
            get { return cnt1; }
        }
        public int Cnt2
        {
            get { return cnt2; }
        }
        
    }
}
