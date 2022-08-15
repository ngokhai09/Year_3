using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*class Point
    {
        private double x;
        private double y;
        public Point()
        {
            x = y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Input()
        {
            Console.Write("Nhap toa do x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = Double.Parse(Console.ReadLine());
        }
        public void Printf()
        {
            Console.WriteLine("Toa do diem: (" + x + ", " + y + ")");
        }
        public double Distance(Point a)
        {
            return Math.Sqrt(Math.Pow(x - a.x, 2) + Math.Pow(y - a.y, 2));
        }
    }*/
    class Ex3_Diem_Toa_Do
    {
        private double x;
        private double y;
        public Ex3_Diem_Toa_Do()
        {
            x = y = 0;
        }
        public Ex3_Diem_Toa_Do(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Input()
        {
            Console.Write("Nhap toa do x: ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = Double.Parse(Console.ReadLine());
        }
        public void Printf()
        {
            Console.WriteLine("Toa do diem: (" + x + ", " + y + ")");
        }
        public double Distance(Ex3_Diem_Toa_Do a)
        {
            return Math.Sqrt(Math.Pow(x - a.x, 2) + Math.Pow(y - a.y, 2));
        }
    }
}
