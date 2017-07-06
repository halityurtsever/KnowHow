using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    internal class Adaptee
    {
        internal string[] GetNames()
        {
            var nameArray = new[] { "Halit", "Aysun", "Yigit", "Ali" };
            return nameArray;
        }
    }
}
