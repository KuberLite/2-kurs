using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class PersonalException: Exception
    {
        public PersonalException(string name) : base(name) {

        }
    }
}
