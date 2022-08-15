using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_LearnEnglish
{
    public class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;
        public BaiTapDienTu() { }

        public BaiTapDienTu(string debai, string dapan)
        {
            this.Debai = debai;
            this.Dapan = dapan;
        }

        public BaiTapDienTu(string debai, string dapan, List<string> dapantungcau)
        {
            this.Debai1 = debai;
            this.Dapan1 = dapan;
            this.Dapantungcau = dapantungcau;
        }

        public string Debai
        {
            get => Debai1; set => Debai1 = value;
        }
        public string Dapan
        {
            get => Dapan1; set => Dapan1 = value;
        }
        public string Debai1
        {
            get => debai; set => debai = value;
        }
        public string Dapan1
        {
            get => dapan; set => dapan = value;
        }
        public List<string> Dapantungcau
        {
            get => dapantungcau; set => dapantungcau = value;
        }

    }
}
