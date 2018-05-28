using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace laba_12.AbstractFactory
{
    abstract class Objects
    {  
            public abstract void draw();
    }

    class Circle : Objects
    {
        public override void draw()
        {
            MessageBox.Show("Создан круг");
        }
    }

    class Rect : Objects
    {
        public override void draw()
        {
            MessageBox.Show("Создан квадрат");
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

        public void draw()
        {
            objects.draw();
        }
     }



}
