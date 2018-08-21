using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class RealDateTime : IDateTime
    {
        public DateTime Date
        {
            get { return DateTime.Now; }
        }

    }
}
