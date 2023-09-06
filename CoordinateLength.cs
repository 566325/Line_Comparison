using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class CoordinateLength
    {
        public static void LengthTwoPoints()
        {
            float x1,x2,y1,y2,Distance;
            Console.WriteLine("Enter X1 =");
            x1=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter X2 =");
            x2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Y1 =");
            y1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Y2 =");
            y2 = Convert.ToSingle(Console.ReadLine());

            Distance = ((x2 - x1) * (x2-x1)+(y2 - y1)*(y2-y1));
            Console.WriteLine("Length of Two Points" + Math.Sqrt(Distance));
        }
    }
}
