using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9
{
    class Hero
    {
        string name = "张三";
        float height = 1.8f;
        float weight = 80.5F;
        public float Bmi()
        {
            return this.weight / (this.height * this.height);
        }
    }
}
