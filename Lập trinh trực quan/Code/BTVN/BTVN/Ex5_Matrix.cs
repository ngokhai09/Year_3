using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Ex5_Matrix
    {
        private int n;
        private int m;
        private int[,] a;
        public Ex5_Matrix()
        {

        }
        public Ex5_Matrix(int m, int n)
        {
            this.m = m;
            this.n = n;
            a = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = 0;
                }
            }
        }
        public void Input()
        {
            Console.Write("Nhap so dong: ");
            m = Int16.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            n = Int16.Parse(Console.ReadLine());
            a = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("Nhap phan tu a[" + i + ", " + j + "]: ");
                    a[i,j] = Int16.Parse(Console.ReadLine());
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);                    
                }
                Console.WriteLine();
            }
        }
        public void Sum(Ex5_Matrix b)
        {
            Ex5_Matrix z = new Ex5_Matrix(m, n);
            if(m == b.m && n == b.n){
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        z.a[i, j] = a[i, j] + b.a[i, j];
                    }
                }
                Console.WriteLine("Ma tran tong la: ");
                z.Print();
            }
            Console.WriteLine("Khong tinh duoc");
        }
        public void Sub(Ex5_Matrix b)
        {
            Ex5_Matrix z = new Ex5_Matrix(m, n);
            if(m == b.m && n == b.n){
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        z.a[i, j] = a[i, j] - b.a[i, j];
                    }
                }
                Console.WriteLine("Ma tran hieu la: ");
                z.Print();
            }
            Console.WriteLine("Khong tinh duoc");
        }
        public void Mul(Ex5_Matrix b)
        {
            Ex5_Matrix z = new Ex5_Matrix(m, b.n);
            if(n == b.m){
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < b.n; j++)
                    {
                        for (int k = 0; k < n; k++)
                            z.a[i, j] += a[i, k] * b.a[k, j];

                        Console.WriteLine("Ma tran tich la: ");
                    }
                        z.Print();
                }
            }
            Console.WriteLine("Khong tinh duoc");
        }
        public void ChuyenVi()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
