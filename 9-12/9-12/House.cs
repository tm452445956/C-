using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_12
{
    class House
    {
        public House() 
        {
        }
        public float leng;
        public float width ;
        public float heigth ;
        public House(float l,float w,float h)
        {
            this.leng = l;
            this.heigth = h;
            this.width = w;
        }
        public void Volume()
        {
            float s = this.width * this.leng * this.heigth;
            Console.WriteLine("房子体积是{0}", s);
        }
    }
}
