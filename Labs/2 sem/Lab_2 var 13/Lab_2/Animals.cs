
using System;

namespace Lab_2
{
    [Serializable]
    public class Animals
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Receipt_date { get; set; }
        public string Squad { get; set; }
        public string Age { get; set; }
        public string Red_Book { get; set; }
        public string Cost { get; set; }

        public Place Place { get; set; }
        public Curator_class Curator_Class{ get; set; }

        public Animals()
        {
        }
    }
}