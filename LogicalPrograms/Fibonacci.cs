using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1=0 , n2=1 , n3, n;
            Console.WriteLine("Enter a number up to which you want the series : ");
            n= Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(n1);
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
