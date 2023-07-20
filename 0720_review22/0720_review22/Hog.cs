using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0720_review22
{
  class Hog : Monster
    {
        public Hog() 
        {
            name = "멧돼지";
            hp = 100;
            mp = 50;

            Console.WriteLine(name +"가 생성되었습니다.");

        }
        ~Hog() 
        {
            Console.WriteLine(name +"멧돼지가 사망했습니다.");
        }    
    }
    }

