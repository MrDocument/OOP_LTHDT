using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class HINH_TRON : HINH
    {
        private DIEM I;
        private double R;

        public override void NhapHinh(string ghiChu)
        {
            base.NhapHinh(ghiChu);
            this.I = new DIEM();
            this.I.NhapDiem("Nhap tam I: ");
            Console.WriteLine("Nhap ban kinh r: ");
            this.R = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * R;
        }
    }
}
