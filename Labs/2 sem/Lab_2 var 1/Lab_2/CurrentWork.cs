
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lab_2
{
    [Serializable]
    public class CurrentWork
    {
        public string Company { get; set; }
        public string Role { get; set; }
        public string Experience { get; set; }

        public CurrentWork()
        {

        }
    }
}