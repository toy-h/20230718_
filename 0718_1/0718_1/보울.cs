using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0718_1
{
    internal class Program
    {//함수 단위로 실행 - 한 줄 (무조건 줄 단위) 
        
        //count 가 지워지고 int 
        //true = 충돌 펄스 = 충돌x 충돌값 확인 
        //ref 가리켜서 사용한다 - 메모리 사용이 다름 

        static bool IsCollide(int position, out int info)
        {
            bool check = false;
            if ( check )
            {
                info = 0;
                return  false;
            }
            else
            { info = 10;
                return true; }
       

        static void Main(string[] args)
        {
            int number = 1;
            //참조해서 쓸 거다 
            Increase(out number);
            Console.WriteLine(number);
        }
    }
}
