using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9
{
    class circle
    {
        float r = 0;
        public double S(string x)
        {
            float r =Convert.ToSingle(x);
            return(r*r)*Math.PI;
        }
    }
}
