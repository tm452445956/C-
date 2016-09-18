using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9
{
    class 作业
    {
        float width;
        float height;
        public 作业(float www,float hhh) 
        {
            this.height = hhh;
            this.width = www;
        }
        public float h
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value < 0 ? 0 : value;
            }
        }
        public float w
        {
            get
            {
                return this.width;
            }
            set
            {
                this.height = value < 0 ? 0 : value;
            }
        }
        public float Area()
        {
            return this.width * this.height;
        }
        public float this[string n]
        {
            get
            {
                if (n == "w")
                    return this.width;
                if (n == "h")
                    return this.height;
                else
                    return -1;
            }
        }
        public void Flip(ref float w, ref float h)
        {
            float t = w;
            w = h;
            h = t;
        }
    }
}
