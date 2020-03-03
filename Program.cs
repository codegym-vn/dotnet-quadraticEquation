using System;

namespace QuadraticEquation
{
    class Program
    {
        public static void Main()
        {
            QuadraticEquation qe = new QuadraticEquation();
            int a, b, c;
            double delta, x1, x2;
            Console.Write("\n");
            Console.Write("Giai phuong trinh bac hai trong C#: \n");
            Console.Write("---------------------------------------------------");

            Console.Write("Nhap gia tri cua a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nNhap gia tri cua c: ");
            c = Convert.ToInt32(Console.ReadLine());

            delta = b * b - 4 * a * c;
            if (delta == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("The equation has one root = {0}\n", x1);
            }
            else if (delta > 0)
            {
                x1 = qe.GetRoot1(a, b, delta);
                x2 = qe.GetRoot2(a, b, delta);

                Console.Write("The equation has two roots {0} and {1}\n", x1, x2);
            }
            else
            {
                Console.Write("The equation has no roots");
            }
            Console.ReadKey();
        }
    }
}