using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab_12.AbstractFactory
{
    class Add : EditElem
    {
        public override void EditElem(TextBox textBox)
        {
            textBox.Text = "Добавлен элемент";
        }
    }
}
