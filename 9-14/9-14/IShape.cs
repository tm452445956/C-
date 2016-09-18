using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_14
{
    interface IShape //全是抽象方法的类
    {
        double Area();
        string name { get; }
    }
}
