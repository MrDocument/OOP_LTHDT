using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class NVVP : NHANVIEN
    {
        //thanh phan du lieu        
        private double HeSo;
        private double PhuCap;

        //thanh phan xu ly
        public override void NhapNV(string ghiChu)
        {
            base.NhapNV(ghiChu);           
            Console.WriteLine("Nhap he so nhan vien:");
            this.HeSo = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap phu cap nhan vien:");
            this.PhuCap = double.Parse(Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return this.HeSo * 10 + this.PhuCap;
        }

        public override void F()
        {
            Console.WriteLine("LOP NHAN VIEN VAN PHONG");
        }
    }
}
