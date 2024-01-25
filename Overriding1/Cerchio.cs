using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding1
{
    internal class Cerchio
    {
        public int Raggio { get; set; }
        public override string ToString()
        {
            return string.Format("2Pi{0}",Raggio);
        }
    }
}
