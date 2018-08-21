using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FakeDateTime : IDateTime
    {

        public DateTime _dateToReturn;

        public FakeDateTime(DateTime dateToReturn)
        {
            _dateToReturn = dateToReturn;
        }

        public DateTime Date
        {
            get { return _dateToReturn; }
        }

    }
}
