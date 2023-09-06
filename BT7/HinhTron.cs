using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HinhTron
    {
        public double banKinh;
        public ToaDo tam;

        public ToaDo getTam()
        {
            return tam;
        }
        public void setTam(ToaDo tam)
        {
            this.tam = tam;
        }
        public double getBanKinh()
        {
            return banKinh;
        }
        public void setBanKinh(double value)
        {
            this.banKinh = value;
        }
        public HinhTron(ToaDo tam,double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }
        public HinhTron() 
        {
            tam = new ToaDo();
            banKinh = 0;
        }
        public void TinhChuViTron()
        {
            double cv = 2 * 3.14 * banKinh;
            Console.WriteLine("\nChu vi hinh tron la: " + cv);
        }
        public void TinhDienTichTron()
        {
            double dt = 3.14 * banKinh * banKinh;
            Console.WriteLine("\nDien tich hinh tron la: " + dt);
        }
        public void Xuat()
        {
            Console.WriteLine(tam + " " + "Co ban kinh " + banKinh);
            TinhChuViTron();
            TinhDienTichTron();
        }

    }
}
