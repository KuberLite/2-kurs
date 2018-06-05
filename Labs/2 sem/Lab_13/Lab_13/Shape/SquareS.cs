using System.Windows;

namespace Lab_13
{
    class SquareS : Shape, IComponent
    {
        public string Title { get; set; }

        public override bool HasStroke()
        {
            return false;
        }

        public override void ShapeStyle()
        {
            MessageBox.Show("Square created");
        }

        public void Draw()
        {
            MessageBox.Show("I was drawn");
        }

        public IComponent Find(string title)
        {
            MessageBox.Show("I've got no map");
            return null;
        }
    }
}