using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TongHopCode
{
    class DIEM
    {
        public int X;
        public int Y;
        public DIEM()
        {
            this.X = 0;
            this.Y = 0;
        }
        public DIEM(int z,int t)
        {
            this.X = z;
            this.Y = t;
        }
        public void NhapDiem(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap vao diem X: ");
            this.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao diem Y: ");
            this.Y = int.Parse(Console.ReadLine());

        }
        public double TinhKhoangCachDiem(DIEM b)
        {
            
            return Math.Sqrt((X - b.X) * (X - b.X)+ (Y - b.Y) * (Y - b.Y));
        }
    }
}
