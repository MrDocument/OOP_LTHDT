using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class PHAN_SO
    {
        //tp du lieu ==> private ==> khong cho ben ngoai truy xuat truc tiep vao
        //private int TuSo;
        private int MauSo;

        //tp xu ly ==> public 
        //Hàm tạo :
        //- Tên hàng trùng tên lớp và không có giá trị trả về
        //- Tự động được gọi khi khởi tạo đối tượng với toán tử NEW
        //- Dùng để khởi tạo những giá trị ban đầu cho đối tượng
        //- Khi không có hàm tạo, trình biên dịch tự dộng phát sinh
        //hàm tạo không đối số
        public PHAN_SO()
        {
            this.TuSo = 0;
            this.MauSo = 1;

        }
        public PHAN_SO(int t,int m)
        {
            this.TuSo = t;
            if (this.MauSo != 0)
            {
                this.MauSo = m;
            }
            else
            {
                this.MauSo = 1;
            }
        }
        public void NhapPhanSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap tu so: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public PHAN_SO CongPhanSo(PHAN_SO b)
        {
            PHAN_SO kq;
            kq = new PHAN_SO();
            kq.TuSo = this.TuSo * b.MauSo + b.TuSo * this.MauSo;
            kq.MauSo = this.MauSo * b.MauSo;
            return kq;

        }
        //public int TU_SO
        //{
        //    get
        //    {
        //        return this.TuSo;
        //    }
        //    set
        //    {
        //        this.TuSo = value;
        //    }
        //}
        public int TuSo { get; set; }//phien ban thu gon
        public int MAU_SO 
        {
            get
            {
                return this.MauSo;
            }
            set 
            {
                if (value != 0)//Kiem tra hop le truoc khi gan
                    this.MauSo = value;
            }
        }
        public string XuatPhanSo()
        {
            return string.Format("{0}/{1}", TuSo, MauSo);
        }
        //public int DocTuSo()
        //{
        //    return this.TuSo;
        //}
        //public void GanTuSo(int t)
        //{ 
        //    this.TuSo = t;
        //}
        //public int DocMauSo()
        //{
        //    return this.MauSo;
        //}
        //public void GanMauSo(int m)
        //{
        //    if (m != 0)//Kiem tra hop le truoc khi gan
        //        this.MauSo = m;
        //}
    }
}
