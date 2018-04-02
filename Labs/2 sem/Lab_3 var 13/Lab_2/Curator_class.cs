
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_2
{
    [Serializable]
    public class Curator_class
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Country { get; set; }

        public Curator_class()
        {

        }
    }
}