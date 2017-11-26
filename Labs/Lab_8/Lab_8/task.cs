using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class task : IComparable
    {
        private double s;
        public int CompareTo(object obj)
        {
            return s.CompareTo(obj);
        }
    }
}
