using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Sea : Vehicle
    {
        string _type;

        public Sea(string color, string type) : base(color)
        {
            _type = type;
        }

        public override string ToString()
        {
            return base.ToString() + $" - It is a {_type}";
        }
    }
}
