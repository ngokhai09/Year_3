using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class SinhVien_plus
    {
        private string ID;
        private string Name;
        private string Birth;
        private string Home;
        private double[] Mark = new double[2];
        private double Arg;

        public SinhVien_plus()
        {

        }
        public SinhVien_plus(string Name, string Birth, string Home, double Code, double DB)
        {
            this.Name = Name;
            this.Birth = Birth;
            this.Home = Home;
            this.Mark[0] = Code;
            this.Mark[1] = DB;
            this.Arg = (Code + DB) / 2;
        }

        public void Input()
        {
            ID = Console.ReadLine();
            Name = Console.ReadLine();
            Birth = Console.ReadLine();
            Home = Console.ReadLine();
            Arg = 0;
            for (int i = 0; i < 2; i++)
            {
                Mark[i] = Double.Parse(Console.ReadLine());
                Arg += Mark[i];
            }
            Arg /= 2;
        }
        public void Print()
        {
            Console.WriteLine("Ma sinh vien: " + this.ID);
            Console.WriteLine("Ten sinh vien: " + this.Name);
            Console.WriteLine("Nam Sinh: " + this.Birth);
            Console.WriteLine("Diem mon Lap trinh: " + this.Mark[0]);
            Console.WriteLine("Diem mon Co so du lieu: " + this.Mark[1]);
        }
        public string getID()
        {
            return ID;
        }
        public bool check()
        {
            if(Arg > 8)
            {
                return true;
            }
            return false;
        }
        
    };
    class Ex1_Quan_Ly_Sinh_Vien_plus
    {
        private int n;
        private List<SinhVien_plus> list_of_SinhVien = new List<SinhVien_plus>();
        public void Input()
        {
            Console.Write("Nhap vao so sinh vien: ");
            n = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien_plus t = new SinhVien_plus();
                t.Input();
                list_of_SinhVien.Add(t);
            }
        }
        public void Print()
        {
            foreach (SinhVien_plus item in list_of_SinhVien)
            {
                Console.WriteLine("---------------------------");
                item.Print();
            }
        }
        public void LietKe()
        {
            Console.WriteLine("Danh sach sinh vien co diem TB > 8 la: ");
            foreach(SinhVien_plus item in list_of_SinhVien)
            {
                if (item.check())
                {
                    item.Print();
                }
            }
        }
        public void sapxep()
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(String.Compare(list_of_SinhVien[i].getID(),list_of_SinhVien[j].getID()) > 0)
                    {
                        SinhVien_plus t = list_of_SinhVien[i];
                        list_of_SinhVien[i] = list_of_SinhVien[j];
                        list_of_SinhVien[j] = list_of_SinhVien[i];
                    }
                }
            }
        }

    }
}
