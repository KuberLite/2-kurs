using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12.AbstractFactory
{
    abstract class FigureFactory
    {
        public abstract EditElem GetEditElem();
        public abstract EditColor GetEditColor();
    }
}
