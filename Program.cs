using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PHANSO a, b;
            a = XL_PHANSO.NhapPhanSo("Nhap phan so a: ");
            b = XL_PHANSO.NhapPhanSo("Nhap phan so b: ");

            PHANSO kq;
            kq = XL_PHANSO.TinhTongPhanSo(a, b);

            string Chuoi = "Ket qua la " + XL_PHANSO.XuatPhanSo(kq);
            Console.WriteLine(Chuoi);
            Console.ReadLine();
            */

            /*
            PHAN_SO a, b;
            a = new PHAN_SO();
            b = new PHAN_SO();

            //Yeu cau doi tuong a thuc hien hanh dong Nhap
            a.NhapPhanSo("Nhap phan so a: ");
            b.NhapPhanSo("Nhap phan so b: ");

            //Yeu cau doi tuong a thuc hien hanh dong CongPS voi b
            PHAN_SO kq;
            kq = a.CongPhanSo(b);
            Console.WriteLine("Ket qua la " + kq.XuatPhanSo());
            Console.ReadLine();
            */
            /*
            DIEM a, b;
            a = new DIEM();
            b = new DIEM();
            //yeu cau doi tuong a thuc hien hanh dong Nhap
            a.NhapDiem("Nhap diem A: ");
            //yeu cau doi tuong b thuc hien hanh dong Nhap
            b.NhapDiem("Nhap diem B: ");

            //yeu cau a thuc hien viec Tinh Khoang Cach voi b
            double kq = a.TinhKhoangCachDiem(b);

            string Chuoi = "Ket qua la " + kq;
            Console.WriteLine(Chuoi);
            */

            /*
            //Tao lap tam giac
            TAMGIAC tg;
            tg = new TAMGIAC();

            //Yeu cau doi tuong tg thuc hien hanh dong Nhap
            tg.NhapTamGiac("Nhap tam giac: ");
            //Yeu cau doi tuong tg thuc hien hanh dong Tinh chu vi
            double kq = tg.TinhChuVi();
            Console.WriteLine("Ket qua la " + kq);
            Console.ReadLine();
            //Tao lao da giac
            */

            /*
            DAGIAC tg;
            tg = new DAGIAC();

            //
            tg.NhapDaGiac("NhapDaGiac: ");

            //
            double kq = tg.TinhChuVi();

            Console.WriteLine("Ket qua la "+kq);
            */

            //Ham tao phan so

            /*
            PHAN_SO a = new PHAN_SO();
            Console.WriteLine(a.XuatPhanSo());

            int t = a.TuSo;
            int m = a.MAU_SO;

            a.TuSo = 6;

            a.MAU_SO = 4;
            a.MAU_SO = 0;

            //PHAN_SO b = new PHAN_SO(2,5);
            Console.WriteLine(a.XuatPhanSo());


            CONGTY A;
            A = new CONGTY();
            A.NhapCongTy("Nhap Cong Ty:");
            double luong = A.TinhTongLuong();
            Console.WriteLine("Tong luong la "+ luong);


            

            Console.ReadLine();

            CONGTY a = new CONGTY();
            a.NhapCongTy("Nhap cong ty: ");
            double kq = a.TinhTongLuong();
            Console.WriteLine(kq);

            MATPHANG b = new MATPHANG();
            b.NhapMatPhang("Nhap mat phang: ");
            double result = b.TinhTongChuVi();
            Console.WriteLine(result);
            */




            //MyIntClass a;
            //MyDoubleClass b;


            MyGenericClass<int> a1;
            MyGenericClass<double> a2;


            MyArray<int> intArr;
            intArr = new MyArray<int>();
            intArr.Init(10);

            for (int i = 0; i < 10; i++)
            {
                
                intArr.Set(i, i + 1);
            }

            intArr.Show();

            
            
            












        }

    }
}
