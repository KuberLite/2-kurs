using System.Windows;
using System.Windows.Controls;

namespace Lab_13
{
    class Square : IMove
    {
        private static Square square;

        public static bool getInstance()
        {
            if(square == null)
            {
                square = new Square();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Move()
        {
            MessageBox.Show("Object is moving");
        }
    }
}
