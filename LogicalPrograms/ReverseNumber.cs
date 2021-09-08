using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            int n,sum=0;
            Console.WriteLine("ENTER A NUMBER");
            n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                int num = n % 10;
                sum = sum * 10 + num;
                n = n / 10;
            }
            Console.WriteLine("THE REVERSE OF A NUMBER IS :"+sum);
            Console.ReadLine();
        }

    }
}
