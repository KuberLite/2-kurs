using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12.AbstractFactory
{
    class CircleFactory : FigureFactory
    {
        public override EditColor GetEditColor()
        {
            return new Red();
        }

        public override EditElem GetEditElem()
        {
            return new Add();
        }
    }
}
