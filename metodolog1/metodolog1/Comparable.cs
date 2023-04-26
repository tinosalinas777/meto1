using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodolog1
{
    internal interface Comparable
    {
        public bool sosIgual(Comparable a);
        public bool sosMenor(Comparable a);
        public bool sosMayor(Comparable a);
    }
}
