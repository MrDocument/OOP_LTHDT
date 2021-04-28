using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class CONGTY
    {
        //thanh phan du lieu
        private string TenCongTy;
        private NHANVIEN[] dsNV;
        

        //thanh phan xu ly
        public void NhapCongTy(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Ten cong ty:");
            this.TenCongTy = Console.ReadLine();

            Console.WriteLine("Nhap so luong nhan vien:");
            int N = int.Parse(Console.ReadLine());
            this.dsNV = new NHANVIEN[N];
            for (int i = 0; i < this.dsNV.Length; i++)
            {
                Console.WriteLine($"Nhap loai nhan vien thu {i}: \n 1.NVVP \n 2.NVSX");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                {
                    this.dsNV[i] = new NVVP();
                }
                else
                {
                    this.dsNV[i] = new NVSX();
                }
                this.dsNV[i].NhapNV($"Nhap thong tin nhan vien: ");
            }

            //Console.WriteLine("Nhap so luong nhan vien san xuat:");
            //int N = int.Parse(Console.ReadLine());
            //this.dsNVSX = new NVSX[N];
            //for (int i = 0; i < this.dsNVSX.Length; i++)
            //{
            //    this.dsNVSX[i] = new NVSX();
            //    this.dsNVSX[i].NhapNV($"Nhap nhan vien san xuat thu {i}:");
            //}

            //Console.WriteLine("Nhap so luong nhan vien van phong:");
            //int P = int.Parse(Console.ReadLine());
            //this.dsNVVP = new NVVP[P];
            //for (int i = 0; i < this.dsNVVP.Length; i++)
            //{
            //    this.dsNVVP[i] = new NVVP();
            //    this.dsNVVP[i].NhapNV($"Nhap nhan vien van phong thu {i}:");
            //}           
            
        }
        public double TinhTongLuong()
        {
            double S = 0;
            for (int i = 0; i < this.dsNV.Length; i++)
            {
                S = S + this.dsNV[i].TinhLuong();
            }
            
            return S;
        }
    }
}
