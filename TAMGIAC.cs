using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class TAMGIAC
    {
        //thanh phan du lieu
        public DIEM A;
        public DIEM B;
        public DIEM C;


        //thanh phan xu ly
        public void NhapTamGiac(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            this.A = new DIEM();
            this.B = new DIEM();
            this.C = new DIEM();
            this.A.NhapDiem("Nhap dinh A:");
            this.B.NhapDiem("Nhap dinh B:");
            this.C.NhapDiem("Nhap dinh C:");
        }
        public double TinhChuVi()
        {
            double a, b, c;
            a = this.B.TinhKhoangCachDiem(this.C);
            b = this.A.TinhKhoangCachDiem(this.C);
            c = this.A.TinhKhoangCachDiem(this.B);
            return a + b + c;
        }

        

    }
}
