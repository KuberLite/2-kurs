namespace lab12
{
    interface ITest1
    {
        int Sum(int a, int b);
    }
    interface ITest2
    {
        double Mult(int a, int b);
    }

    class TestClass : ITest1, ITest2
    {
        private int i;
        public int j;
        public int k { get; set; }

        public TestClass()
        {
            i = 1;
            j = 2;
            k = 3;
        }

        public int Sum(int a, int b)
        {
            return i + j + k + a + b;
        }
        public double Mult(int a, int b)
        {
            return i * j * k * a * b;
        }
    }
}
