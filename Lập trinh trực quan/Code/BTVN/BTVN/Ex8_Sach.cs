using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Ex8_Sach
    {
        private string ID;
        private string Book_Name;
        private string Author_Name;
        private int NumberofBook;
        public void Input()
        {
            Console.Write("Nhap ma sach");
            ID = Console.ReadLine();
            Console.Write("Nhap ten sach");
            Book_Name = Console.ReadLine();
            Console.Write("Nhap ten tac gia");
            Author_Name = Console.ReadLine();
            Console.Write("Nhap so luong sach");
            NumberofBook = Int16.Parse(Console.ReadLine());
        }
        public void Ouput()
        {
            Console.Write("Ma sach: {0}", ID);
            Console.Write("Ten sach: {0}", Book_Name);
            Console.Write("Ten tac gia: {0}", Author_Name);
            Console.Write("So luong sach: {0}", NumberofBook);
        }
    }
}
