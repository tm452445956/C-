using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_14
{
    class Triangle:IShape
    {
        public float w;
        public float h;
        public Triangle(float w, float h)
        {
            this.w = w;
            this.h = h;
        }
        double IShape.Area()
        {
            return (this.w * this.h) / 2;
        }
        string IShape.name
        {
            get { return "三角形"; }
        }
    }
}
