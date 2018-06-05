using System.Collections.Generic;
using System.Windows;

namespace Lab_13
{
    public class Map : IComponent
    {
        private readonly List<IComponent> _map = new List<IComponent>();

        public string Title { get; set; }

        public void AddComponent(IComponent component)
        {
            _map.Add(component);
        }

        public void Draw()
        {
            foreach(IComponent comp in _map)
            {
                MessageBox.Show(comp.Title);
            }
        }

        public IComponent Find(string title)
        {
            foreach(IComponent c in _map)
            {
                if (c.Title == title)
                    return c;
            }
            return null;
        }
    }
}