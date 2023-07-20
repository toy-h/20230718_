using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0720_review22
{
 class Monster
    {
    public Monster() 
        {
            name = "몬스터";
            hp = 50;
              mp = 30;
            Console.WriteLine(name +"이/가 생성되었습니다." );
        }
     //   public Monster(int hp, int mp);
        public int hp;
        public int mp;
        public string name = string.Empty;
        ~ Monster() 
        {
            Console.WriteLine(name + "이/가 사망했습니다.");
        }
    }
}
