    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class NHANVIEN
    {
        public int money;//Co the truy xuat tu bat ky dau
        protected int manv;//Duoc phep truy xuat trong pham vi class + trong cac lop ke thua
        private string tennv;//chi duoc phep truy xuat trong pham vi class
        private string diachi;
        public virtual void NhapNV(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ma nhan vien:");
            this.manv = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ten nhan vien:");
            this.tennv = Console.ReadLine();
            Console.WriteLine("Nhap dia chi nhan vien:");
            this.diachi = Console.ReadLine();
            //Console.WriteLine("Nhap he so nhan vien:");
            //this.HeSo = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap phu cap nhan vien:");
            //this.PhuCap = double.Parse(Console.ReadLine());
        }

        public virtual void F()
        {
            Console.WriteLine("LOP NHAN VIEN");
        }
            
        public virtual double TinhLuong()
        {
            return 0;
        }

    }
}
