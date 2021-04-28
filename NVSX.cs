using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class NVSX : NHANVIEN
    {
        //thanh phan du lieu
        
        private double SoSanPham;

        //thanh phan xu ly
        public override void NhapNV(string ghiChu)
        {
            
            base.NhapNV(ghiChu);          
            Console.WriteLine("Nhap so san pham:");
            this.SoSanPham = double.Parse(Console.ReadLine());
            
        }
        public override double TinhLuong()
        {
            return this.SoSanPham * 100;
        }

        public override void F()
        {
            Console.WriteLine("LOP NHAN VIEN SAN XUAT");
        }
    }
}
