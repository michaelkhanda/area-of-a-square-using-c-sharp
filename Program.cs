using System;

namespace Areaofasquare
{
    class Program
    {
        static int Perimeter(out int l)
        {
            l = 7;
            int p = l * 4;
            return p;
        }
        static int SquareArea( out int l)
        {
            l = 2;
            l = l + 2;
            int area = l * l;
            return area;
        }
        static void Main(string[] args)
        {
            int length = 8;
            int area = SquareArea(out length);
            Console.WriteLine("The area is: " + area);
            int p = Perimeter(out length);
            Console.WriteLine("The area is: " + p);
            Console.WriteLine("The final length is" +" " + length);









        }
    }
}
