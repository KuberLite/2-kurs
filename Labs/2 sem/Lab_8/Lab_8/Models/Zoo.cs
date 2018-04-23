using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8.Models
{
    public class Zoo
    {
        public int ZooId { get; set; }

        public string NameZoo { get; set; }

        public int SizeZoo { get; set; }

        public Animals Animals { get; set; }
    }
}
