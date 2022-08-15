using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Tinh_lai_suat_tiet_kiem
{
    class KhachHang
    {
        private int ID;
        private string Name;
        private string Address;
        private DateTime Day;
        private int Pre;
        private int Present;
        private double Money;
        public KhachHang()
        {

        }
        public KhachHang(int ID, string Name, string Address, DateTime Day, int Pre, int Present)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Day = Day;
            this.Pre = Pre;
            this.Present = Present;
            this.Money = Bill();
        }
        private double Bill()
        {
            double td = 0;

            int so = Present - Pre;
            if (so <= 50)
            {
                td = so * 100;
            }
            else if (so > 50 && so <= 100)
            {
                td = 50 * 100 + (so - 50) * 200;
            }
            else if (so > 100 && so <= 200)
            {
                td = 50 * 100 + 50 * 200 + (so - 100) * 300;
            }
            else
            {
                td = 50 * 100 + 50 * 200 + 100 * 300 + (so - 200) * 400;
                td += td * 0.1;
            }

            return td;
        }
        public override string ToString()
        {
            return ID + " | " + Name + " | " + Address + " | " + Day + " | " + Pre + " | " + Present + " | " + Money;

        }
        public string Print()
        {
            return Name + " | " + Money;
        }
        public string Ten
        {
            get { return Name; }
        }
    }
}
