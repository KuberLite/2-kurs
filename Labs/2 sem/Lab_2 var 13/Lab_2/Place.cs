using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_2
{
    [Serializable]
    public class Place
    {
        public string Continent { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string District { get; set; }
        public string Area { get; set; }
        
        public Place()
        {

        }
    }
}