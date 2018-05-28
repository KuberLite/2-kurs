using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab_12.AbstractFactory
{
    class Blue : EditColor
    {
        public override void NewColor(TextBox textBox)
        {
            textBox.Text = "Изменения цвета на синий";
        }
    }
}
