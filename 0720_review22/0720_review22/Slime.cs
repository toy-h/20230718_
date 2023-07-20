using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0720_review22
{
     class Slime : Monster
    {
        public Slime() 
        {
            name = "슬라임";
            hp = 100;
            mp = 50;

            Console.WriteLine(name +"이 생성되었습니다.");
        }

        ~Slime() 
        {
            Console.WriteLine(name + "이 사망했습니다.");
        }
    }
}
