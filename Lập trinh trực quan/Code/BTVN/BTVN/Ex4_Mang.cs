using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Ex4_Mang
    {
        private int n;
        private int[] a;
        public Ex4_Mang(int n)
        {
            this.n = n;
            a = new int[n];
            Array.Clear(a, 0, n);
        }
        public Ex4_Mang()
        {
            
        }
        public void Input()
        {
            Console.Write("Nhap so phan tu: ");
            n = Int16.Parse(Console.ReadLine());
            a = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
                a[i] = Int16.Parse(Console.ReadLine());
            }
        }
        public void Print()
        {
            Console.Write("Phan tu cua mang la: ");
            foreach(int item in a)
            {
                Console.Write(item + " ");
            }
        }
        public void swap(ref int x,  ref int y)
        {
            x += y;
            y = x - y;
            x -= y;
        }
        public void sapxep(int thutu)
        {
            if(thutu == 0)
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = i + 1; j < n; j++)
                    {
                        if(a[i] > a[j])
                        {
                            swap(ref a[i],ref a[j]);
                        }
                    }
                    
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] < a[j])
                        {
                            swap(ref a[i], ref a[j]);
                        }
                    }

                }
            }
            
        }
        public int BinarySeacrh(int l, int r,int x)
        {
            sapxep(1);
            if(l <= r)
            {
                int mid = (l + r) / 2;
                if (a[mid] == x) return mid;
                if (a[mid] > x) return BinarySeacrh(l, mid - 1, x);
                if (a[mid] < x) return BinarySeacrh(mid + 1, r, x);
            }
            return -1;
        }
        public int Search(int x)
        {
            for(int i = 0; i < n; i++)
            {
                if (a[i] == x)
                    return i;
            }
            return -1;
        }
    }
}
