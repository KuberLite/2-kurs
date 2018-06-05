namespace Lab_13
{
    abstract class Decorator : Shape
    {
        protected Shape Shape;

        public Decorator(Shape shape)
        {
            Shape = shape;
        }
    }
}