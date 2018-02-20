using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_2
{
    [Serializable]
    public class Adress
    {
        public string City { get; set; }
        public string Index { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        
        public Adress()
        {

        }
    }
}