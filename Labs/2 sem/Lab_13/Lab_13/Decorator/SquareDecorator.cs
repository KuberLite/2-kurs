using System.Windows;

namespace Lab_13
{
    class SquareDecorator : Decorator
    {
        public SquareDecorator(Shape s) : base(s) { }

        public override bool HasStroke()
        {
            return true;
        }

        public override void ShapeStyle()
        {
            MessageBox.Show("DecoratorCircle created");
        }
    }
}