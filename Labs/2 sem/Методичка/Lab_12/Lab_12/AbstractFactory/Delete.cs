using System;
using System.Windows.Controls;

namespace Lab_12.AbstractFactory
{
    class Delete : EditElem
    {
        public override void EditElem(TextBox textBox)
        {
            textBox.Text = "Удалён элемент";
        }
    }
}
