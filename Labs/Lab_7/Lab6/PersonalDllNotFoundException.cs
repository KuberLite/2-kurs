using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class PersonalDllNotFoundException : DllNotFoundException
    {
        public PersonalDllNotFoundException(string name) : base(name)
        {

        }
    }
}
