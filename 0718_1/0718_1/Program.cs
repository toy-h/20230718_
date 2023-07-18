using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_1
{
    internal class Program
    {
        
        //count 가 지워지고 int 
        static void Increase(ref int count)
        {
            count++;
        }

       

        static void Main(string[] args)
        {
            int number = 1;
            //참조해서 쓸 거다 
            Increase(ref number);
            Console.WriteLine(number);
        }
    }
}
