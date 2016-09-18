using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_14
{
    class Circle:IShape
    {
        public float r;
        public Circle(float r)
        {
            this.r = r;
        }


        double IShape.Area()
        {
            return Math.PI * r * r;
        }


        string IShape.name
        {
            get {return "圆形"; }
        }
    }
}
