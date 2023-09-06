using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ToaDo x = new ToaDo("A",5, 5);
            HinhTron hinhtron = new HinhTron(x, 10.5);
            hinhtron.Xuat();
            Console.ReadKey();
        }
    }
}
