using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab_13
{
    class SquareAdapter : IMoveAdapter
    {
        Square square;

        public SquareAdapter(Square s)
        {
            square = s;
        }

        public void MoveAdapter()
        {
            square.Move();
        }
    }
}
