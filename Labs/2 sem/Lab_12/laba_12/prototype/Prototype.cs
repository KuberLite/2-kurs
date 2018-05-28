using System;
using System.Windows;
using System.Windows.Controls;

namespace laba_12.prototype
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo(TextBox textBox);
    }

    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo(TextBox textBox)
        {
            MessageBox.Show("Height of rectangle " + height.ToString() + " and width of rectanle " + width.ToString());
        }
    }

    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }

        public void GetInfo(TextBox textBox)
        {
            MessageBox.Show("Radius of circle: " + radius.ToString());
        }
    }
}