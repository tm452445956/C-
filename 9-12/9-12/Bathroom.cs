using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class Bathroom:House
    {
        public void Bath() 
        {
            Console.WriteLine("正在洗澡");
            Console.WriteLine("长:{0},宽:{1},高:{2}",base.leng,base.width,base.heigth);
        }
        public Bathroom(float l, float w, float h): base(l, w, h)
        { 
        }
    }
}
