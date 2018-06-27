using Lab_13.Color;

namespace Lab_13
{
    class MyObject
    {
        private Shape shape;

        private ColorStyle colorStyle;

        public void Color()
        {
            colorStyle.ColorTag();
        }

        public void Shape()
        {
            shape.ShapeStyle();
        }

        public bool HasStroke()
        {
            return shape.HasStroke();
        }
    }
}