using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding1
{
    internal class Rettangolo
    {
        public int lato { get; set; }
        public override string ToString()
        {
            return string.Format("{0}*{1}",lato,lato);
        }
    }
}
