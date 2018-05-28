using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12.AbstractFactory
{
    class TriangleFactory : FigureFactory
    {
        public override EditColor GetEditColor()
        {
            return new Blue();
        }

        public override EditElem GetEditElem()
        {
            return new Delete();
        }
    }
}
