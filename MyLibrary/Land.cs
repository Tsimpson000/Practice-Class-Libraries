using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Land : Vehicle
    {
        int _wheels;

        public Land(string color, int wheels) : base(color)
        {
            _wheels = wheels;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Number of wheels {_wheels}";
        }
    }
}
