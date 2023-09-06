using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class GreterAndLess
    {
        public static void CheckLines()
        {
            float x1, x2, y1, y2, Length1;
            Console.WriteLine("Enter X1 =");
            x1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter X2 =");
            x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Y1 =");
            y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Y2 =");
            y2 = Convert.ToSingle(Console.ReadLine());


            float a1, a2, b1, b2, Length2;
            Console.WriteLine("Enter a1 =");
            a1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter a2 =");
            a2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter b1 =");
            b1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter b2 =");
            b2 = Convert.ToSingle(Console.ReadLine());

            Length1 = ((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of Two Points" + Math.Sqrt(Length1));

            Length2 = ((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            Console.WriteLine("Length of Two Points" + Math.Sqrt(Length2));


            if (Length1 == Length2)
            {
                Console.WriteLine("the lines are Equal");
            }
            else if (Length2 > Length1)
            {
                Console.WriteLine("the line two is greterthan the first line");

            }
            else
            {
                Console.WriteLine("The line one is greterthan the line two");
            }
        }
    }
}
