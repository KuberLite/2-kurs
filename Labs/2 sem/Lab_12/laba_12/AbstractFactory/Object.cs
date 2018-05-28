using System.Windows;
using System.Windows.Controls;

namespace laba_12.AbstractFactory
{
    abstract class Objects
    {  
            public abstract void draw(TextBox textBox);
    }

    class Circle : Objects
    {
        public override void draw(TextBox textBox)
        {
            textBox.Text = "Created circle";
        }
    }

    class Rect : Objects
    {
        public override void draw(TextBox textBox)
        {
            textBox.Text = "Created square";
        }
    }


    abstract class DrawFactory
    {
        public abstract Objects Objects();
        
    }

     class DrawCircle : DrawFactory
    {
        public override Objects Objects()
        {
            return new Circle();
        }
    }

    class DrawRect : DrawFactory
    {
        public override Objects Objects()
        {
            return new Rect();
        }
    }

     class NewObject
    {
        private Objects objects;
        public NewObject(DrawFactory factory)
        {
            objects = factory.Objects();
        }

        public void draw(TextBox textBox)
        {
            objects.draw(textBox);
        }
     }



}
