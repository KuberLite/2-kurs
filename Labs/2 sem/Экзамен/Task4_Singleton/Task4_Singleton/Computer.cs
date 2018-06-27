namespace Task4_Singleton
{
    class Computer
    {
        public OS OS { get; set; }

        public void Launch(string osName)
        {
            OS = OS.GetInstance(osName);
        }
    }
}