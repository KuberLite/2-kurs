using System;
using System.Windows.Controls;

namespace Lab_12.AbstractFactory
{
    class Red : EditColor
    {
        public override void NewColor(TextBox textBox)
        {
            textBox.Text = "Цвет изменён на красный";
        }
    }
}
