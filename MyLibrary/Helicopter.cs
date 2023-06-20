using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Helicopter : Air
    {
        int _numberOfPropellers;
        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            _numberOfPropellers = numberOfPropellers;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Propellers {_numberOfPropellers}";
        }
    }
}
