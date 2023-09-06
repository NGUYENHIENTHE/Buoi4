using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToaDo
    {
        public string ten;
        public float x, y;

        public string getTen()
        {
            return ten;
        }
        public void setTen(string value)
        {
            this.ten = value;
        }
        public float getX()
        {
            return x;
        }
        public void setX(float value)
        {
            this.x = value;
        }
        public float getY()
        {
            return y;
        }
        public void setY(float value)
        {
            this.y = value;
        }
        public ToaDo(string ten,float x,float y)
        {
            this.ten = ten;
            this.x = x;
            this.y = y;
        }
        public ToaDo()
        {
            ten = "O";
            x = 0;
            y = 0;
        }
        public override string ToString()
        {
            return "Toa do" +" "+ ten + "(x,y): " + ten + "("+ x + "," + y+")";
        }
    }
}
