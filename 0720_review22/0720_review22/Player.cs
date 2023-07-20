using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0720_review22
{
     class Player
    {
        public Player() 
        {
            name = "플레이어";
            hp = 100;
             mp = 50;
           gold = 1000;
            Console.WriteLine("플레이어가 생성되었습니다.");

        }
        public string name=string.Empty;
        public int hp;
        public int mp;
        public int gold;
        public void Attack ()
        {
            Console.WriteLine("플레이어가 공격했습니다." );
        }

        public void Move()
        {
            Console.WriteLine("플레이어가 이동합니다. ");
        }

        public void Die()
        {
            Console.WriteLine();
        }
       ~ Player() 
        {
            Console.WriteLine("플레이어가 삭제되었습니다.");
        }
    }
}
