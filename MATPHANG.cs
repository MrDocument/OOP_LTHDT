using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class MATPHANG
    {
        //thanh phan du lieu
        private HINH[] dsHinh;
        //private HINH_TRON[] dsHinhTron;
        //private HCN[] dsHCN;

        //thanh phan xu ly
        public void NhapMatPhang(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap so luong hinh: ");
            int n = int.Parse(Console.ReadLine());
            this.dsHinh = new HINH[n];
            for (int i = 0; i < dsHinh.Length; i++)
            {
                Console.WriteLine($"Nhap vao loai hinh thu {i}: \n 1.Hinh Tron, \n 2.Hinh Chu Nhat");
                int loaiHinh = int.Parse(Console.ReadLine());
                if(loaiHinh == 1)
                {
                    this.dsHinh[i] = new HINH_TRON();
                }
                else
                {
                    this.dsHinh[i] = new HCN();
                }
                this.dsHinh[i].NhapHinh($"Nhap hinh thu {i}: ");
            }
            /*
            this.dsHinhTron = new HINH_TRON[n];
            for (int i = 0; i < dsHinhTron.Length; i++)
            {
                this.dsHinhTron[i] = new HINH_TRON();
                this.dsHinhTron[i].NhapHinh($"Nhap hinh tron thu {i}: ");
            }

            Console.WriteLine("Nhap so luong hinh chu nhat: ");
            n = int.Parse(Console.ReadLine());
            this.dsHCN = new HCN[n];
            for (int i = 0; i < dsHCN.Length; i++)
            {
                this.dsHCN[i] = new HCN();
                this.dsHCN[i].NhapHinh($"Nhap so luong HCN thu {i}: ");
            }
            */
            
        }

        public double TinhTongChuVi()
        {
            double S = 0;

            for (int i = 0; i < this.dsHinh.Length; i++)
            {
                S = S + this.dsHinh[i].TinhChuVi();
            }
            //for (int i = 0; i < this.dsHinhTron.Length; i++)
            //{
            //    S = S + this.dsHinhTron[i].TinhChuVi();
            //}
            //for (int i = 0; i < this.dsHCN.Length; i++)
            //{
            //    S = S + this.dsHCN[i].TinhChuVi();
            //}
            return S;
        }
        

    }
}
