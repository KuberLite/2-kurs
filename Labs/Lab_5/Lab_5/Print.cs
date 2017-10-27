using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Print
    {
        public virtual string Prints(Object obj)
        {
            if(obj is Water)
            {
                Console.WriteLine("Object is 'Water'");
            }
            if(obj is Land)
            {
                Console.WriteLine("Object is 'Land'");
            }
            if(obj is Continent)
            {
                Console.WriteLine("Object is 'Continent'");
            }
            if(obj is State) {
                Console.WriteLine("Object is 'State'");
            }
            if(obj is Sea)
            {
                Console.WriteLine("Object is 'Sea'");
            }
            if(obj is Lake)
            {
                Console.WriteLine("Object is 'Lake'");
            }
            return obj.ToString() + '\n';
        }
    }
}
