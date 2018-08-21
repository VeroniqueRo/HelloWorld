using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FakeDateTime : IDateTime
    {
        public DateTime Date
        {
            get { return new DateTime(2018, 8, 21, 10, 47, 0); }
        }

    }
}
