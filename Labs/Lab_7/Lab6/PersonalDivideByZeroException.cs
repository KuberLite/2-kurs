using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class PersonalDivideByZeroException: DivideByZeroException
    {
        public PersonalDivideByZeroException(string name): base(name) {
            Console.WriteLine(Message);
            Console.WriteLine(StackTrace);
        }
    }
}
