
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

        //Куратор
        public string Surname { get; set; }
        public string Name_curator { get; set; }
        public string Otchestvo { get; set; }
        public string Country { get; set; }

        //Место
        public string Continent { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string District { get; set; }
        public string Area { get; set; }

        public Animals()
        {
        }
    }
}