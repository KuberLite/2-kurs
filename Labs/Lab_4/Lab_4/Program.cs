using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Класс - стек Stack.Дополнительно перегрузить следующие операции: 
+ - добавить элемент в стек;
-- - извлечь элемент из стека;
true - проверка, пустой ли стек;
> - копирование одного стека в другой с сортировкой в возрастающем порядке.
Методы расширения:
1) Подсчет количества предложений
2) Определение среднего элемента стека*/

namespace Lab_4
{
    class Program
    {
        public const int count_stack = 12;
        class GetStack
        {            
            public Stack<int> myStack = new Stack<int>();
            public Stack<int> myStack2 = new Stack<int>();
            public Stack<int> myStack3 = new Stack<int>();

            public int[] arr = new int[count_stack];

            public GetStack()
            {
                Random rand = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < count_stack; i++)
                {
                    myStack.Push(rand.Next(1, 100));
                }
            }

            public static GetStack operator +(int h, GetStack stack)
            {
                stack.myStack.Push(h);
                return stack;
            }
            public static GetStack operator --(GetStack stack)
            {
                stack.myStack.Pop();
                return stack;
            }

            public static bool operator true(GetStack stack)
            {
                if(stack.myStack != null)
                    return true;
                return false;
            }

            public static bool operator false(GetStack stack)
            {
                if (stack.myStack == null)
                    return false;
                return true;
            }

            public static GetStack operator >(GetStack stack, GetStack stack2)
            {
                int count = 0;
                foreach (int value in stack.myStack)
                {
                    stack.arr[count] = value;
                    count++;
                }

                Array.Sort(stack.arr);

                Console.WriteLine("------------After .Sort-------------");

                for (int i = 0; i < count_stack; i++)
                {
                    Console.WriteLine("elem #" + i + ": " + stack.arr[i]);
                }

                

                foreach (int value in stack.arr)
                {
                    stack2.myStack2.Push(value);
                }

                Console.WriteLine("------------Second Stack-------------");
                count = 0;
                foreach (int value in stack2.myStack2)
                {
                    count++;
                    Console.WriteLine("elem #" + count + ": " + value);
                }
                return stack2;
            }

            public static GetStack operator <(GetStack stack, GetStack stack2)
            {
                return stack;
            }

        }

        static void Main(string[] args)
        {
            GetStack forstack = new GetStack();
            GetStack forstack2 = new GetStack();
            GetStack forstack3 = new GetStack();

            forstack = 3 + forstack;

            int count = 0;

            foreach (int value in forstack.myStack)
            {
                count++;
                Console.WriteLine("elem #" + count + ": " + value);
            }

            Console.WriteLine("------------After .Pop-------------");

            forstack--;

            count = 0;
            foreach (int value in forstack.myStack)
            {
                count++;
                Console.WriteLine("elem #" + count + ": " + value);
            }

            if (true)
            {
                Console.WriteLine("Stack isn't empty");
            }

            forstack3 = forstack > forstack2;


            //---------------------------------------

            Console.WriteLine("Средний элемент #" + forstack.myStack.CountPoint() + "\nКол-во строк в стеке: " + forstack.myStack.CountPointElem());

            MakeId.UnderMakeId owner = new MakeId.UnderMakeId();

            owner.UnderMakeID();

        }
    }

    public class MakeId
    {
        public void MakeID()
        {
            Console.WriteLine("MakeId");
        }
        public class UnderMakeId
        {
            public void UnderMakeID()
            {
                int id = 6;
                string name = "Denis";
                string nameoforganization = "BelDen";
                var date = DateTime.Today;

                Console.WriteLine("ID = " + id + "\nName is " + name + "\nName of organization " + nameoforganization + "\nDate: " + date.ToString("D"));
            }
        }
    }

    static class GetElem
    {
        static public int CountPoint(this Stack<int> num)
        {
            int snum;
            snum = num.Count() / 2;
            num.Push(snum);
            return snum;
        }

        static public int CountPointElem(this Stack<int> num)
        {
            return num.Count();
        }
    }
}