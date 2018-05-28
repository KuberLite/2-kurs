using System.Windows;

namespace laba_12.Singleton
{
    class Singleton { }

    class Rhombus
    {
        public bool check;
        
        public NameObject Nameobject { get; set; }

        public void Launch(string osName)
        {
            Nameobject = NameObject.getInstance(osName);
            check = true;
        }
    }

    class NameObject
    {
        private static NameObject instance;

        public string Name { get; private set; }

        protected NameObject(string name)
        {
            this.Name = name;
        }

        public static NameObject getInstance(string name)
        {
            if (instance == null)
                instance = new NameObject(name);
            return instance;
        }
    }
}