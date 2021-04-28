using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class HCN : HINH
    {
        private DIEM A;
        private double d;
        private double r;
        
        public override void NhapHinh(string ghiChu)
        {
            base.NhapHinh(ghiChu);
            this.A = new DIEM();
            this.A.NhapDiem("Nhap dinh A: ");
            Console.WriteLine("Nhap chieu dai: ");
            this.d = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            this.r = double.Parse(Console.ReadLine());
        }
        public override double TinhChuVi()
        {
            return 2 * (this.d + this.r);
        }
    }
}
