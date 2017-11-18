using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{

    struct Area
    {
        public Sea[] sea;
        public Island island;
    }


    class Message
    {
        private List<Area> sea_sea;

        public Message()
        {
            sea_sea = new List<Area>();
        }

        public void PrintStateInContinent(string str)
        {
            if (str == "Australia")
            {
                Console.WriteLine("Australia");
            }
            else if (str == "Eurasia")
            {
                Console.WriteLine("######\n China\n Russia\n Belarus\n France\n Germany\n Italy\n Korea\n India\n Iran\n Greece");
            }
            else if (str == "North America")
            {
                Console.WriteLine("######\n USA\n Mexica\n Canada\n Cuba\n Jamaica\n San-Marino\n Panama");
            }
            else { Console.WriteLine("Wrong Continent"); }
        }        

        public void Add()
        {
            Area obj = new Area();
            obj.sea = new Sea[9];
            for (int i = 0; i < 9; i++)
            {
                obj.sea[i] = new Sea();
            }
            obj.island = new Island();
            sea_sea.Add(obj);
        }


        public int getNumberOfSeas()
        {
            return sea_sea.Count;
        }

        public string foundState()
        {
            return "lol";
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index > sea_sea.Count)
                return;
            sea_sea.RemoveAt(index);
        }

        public void PrintNamesIsland()
        {
            Console.Write("All names of island:\n");
            foreach (var i in sea_sea)
            {
                Console.Write(" - " + i.island.getName() + "\n");
            }
        }
    }
}
