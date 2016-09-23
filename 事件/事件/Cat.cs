using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件
{
    class Cat
    {
        public delegate void Catup();
        public event Catup actions;
        public void Walk(string area)
        {
            if (area == "二楼")
                actions();
        }
    }
}
