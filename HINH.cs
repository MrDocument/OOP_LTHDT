using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class HINH
    {
        private string ten;
        private string mausac;
        public virtual void NhapHinh(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten hinh: ");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap mau sac: ");
            this.mausac = Console.ReadLine();

        }
        public virtual double TinhChuVi()
        {
            return 0;
        }
    }
    
}
