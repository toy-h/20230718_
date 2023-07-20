using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0720_review22
{
 class Goblin : Monster 
    {
        public Goblin()
        {
           name = "고블린";
             hp = 100;
            mp = 50;

            Console.WriteLine(name + "이 생성되었습니다.");
        }
        ~ Goblin() 
        {
            Console.WriteLine(name + "이 사망했습니다.");
        }
    }
}
