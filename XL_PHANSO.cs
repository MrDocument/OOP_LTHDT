using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    public struct PHANSO
    {
        public int TuSo;
        public int MauSo;
    }
    class XL_PHANSO
    {
        public static PHANSO NhapPhanSo(string ghiChu)
        {
            PHANSO kq;
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap Tu So: ");
            kq.TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Mau So: ");
            kq.MauSo = int.Parse(Console.ReadLine());
            return kq;
        }
        public static PHANSO TinhTongPhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.TuSo = a.TuSo * b.MauSo + b.TuSo * a.MauSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
        public static string XuatPhanSo(PHANSO kq)
        {
            return string.Format("{0}/{1}", kq.TuSo, kq.MauSo);
        }


    }
}
