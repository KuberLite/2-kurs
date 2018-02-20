using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab_10
{
    class Person
    {
        public string Country;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int del, caseSwitch = 0, searchItem, delItem, searchSorted;
            ArrayList arraylist = new ArrayList();
            Random random = new Random();
            Queue<int> queue = new Queue<int>();
            do
            {
                Console.Clear();
                Console.Write("1. ArrayList\n2. Queue|SortedDictionary\n3. SortedDictionary with class\n4. ObservableCollection\n0. Exit\n");
                Console.Write(">>");
                caseSwitch = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (caseSwitch)
                {
                    default:
                        Console.Write("Error: wrong number\n");
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 1:
                        for (int i = 0; i < 5; i++)
                        {
                            arraylist.Add(random.Next(15, 100));
                        }

                        arraylist.Add("ArrayList");

                        Console.WriteLine(arraylist.Count + " elements");

                        Console.Write("{ ");
                        foreach (object o in arraylist)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine("}");

                        Console.WriteLine("Delete element number: ");
                        del = Convert.ToInt32(Console.ReadLine());
                        arraylist.RemoveAt(del);

                        Console.WriteLine("------New list------");

                        Console.WriteLine(arraylist.Count + " elements");

                        Console.Write("{ ");
                        foreach (object o in arraylist)
                        {
                            Console.Write(o + " ");
                        }
                        Console.WriteLine("}");

                        Console.WriteLine("Enter the item number to search: ");

                        searchItem = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("It is " + arraylist[searchItem]);

                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        for (int i = 0; i < 10; i++)
                        {
                            queue.Enqueue(random.Next(50, 100));
                        }

                        Console.WriteLine(queue.Count + " elements");

                        Console.Write("{ ");

                        foreach (int num in queue)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine("}");

                        Console.WriteLine();

                        Console.WriteLine("Enter the number of items to delete: ");
                        delItem = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < delItem; i++)
                        {
                            queue.Dequeue();
                        }

                        Console.Write("{ ");

                        foreach (int num in queue)
                        {
                            Console.Write(num + " ");
                        }
                        Console.WriteLine("}");

                        SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();
                        int k = 0;
                        foreach (int num in queue)
                        {
                            sortedDictionary.Add(k, num);
                            k++;
                        }

                        Console.WriteLine("--------sortedDictionary------");

                        Console.Write("{ ");    
                        for (int i = 0; i < sortedDictionary.Count; i++)
                        {
                            Console.Write(sortedDictionary[i] + " ");
                        }

                        Console.WriteLine("}");

                        Console.WriteLine("Enter the item number to search: ");
                        searchSorted = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Your number: " + sortedDictionary[searchSorted]);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        int delCountry, searchSortedCountry;
                        Queue<Person> queuePerson = new Queue<Person>();
                        queuePerson.Enqueue(new Person() { Country = "Belarus" });
                        queuePerson.Enqueue(new Person() { Country = "Russia" });
                        queuePerson.Enqueue(new Person() { Country = "Poland" });
                        queuePerson.Enqueue(new Person() { Country = "Ukraine" });
                        queuePerson.Enqueue(new Person() { Country = "France" });
                        queuePerson.Enqueue(new Person() { Country = "UK" });
                        queuePerson.Enqueue(new Person() { Country = "USA" });
                        queuePerson.Enqueue(new Person() { Country = "Greece" });

                        Console.WriteLine(queuePerson.Count + " elements");

                        Console.Write("{ ");

                        foreach (Person num in queuePerson)
                        {
                            Console.Write(num.Country + " ");
                        }
                        Console.WriteLine("}");

                        Console.WriteLine();

                        Console.WriteLine("Enter the number of country to delete: ");
                        delCountry = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < delCountry; i++)
                        {
                            queuePerson.Dequeue();
                        }

                        Console.Write("{ ");

                        foreach (Person num in queuePerson)
                        {
                            Console.Write(num.Country + " ");
                        }
                        Console.WriteLine("}");

                        Console.WriteLine();

                        SortedDictionary<int, Person> sortedDictionaryPerson = new SortedDictionary<int, Person>();
                        int countPerson = 0;
                        foreach (Person num in queuePerson)
                        {
                            sortedDictionaryPerson.Add(countPerson, num);
                            countPerson++;
                        }

                        Console.WriteLine("--------sortedDictionary------");

                        Console.Write("{ ");
                        for (int i = 0; i < sortedDictionaryPerson.Count; i++)
                        {
                            Console.Write(sortedDictionaryPerson[i].Country + " ");
                        }
                        Console.WriteLine("}");
                        Console.WriteLine("Enter the item number to search: ");
                        searchSortedCountry = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Your number: " + sortedDictionaryPerson[searchSortedCountry].Country);
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        ObservableCollection<Person> person = new ObservableCollection<Person>
                        {
                            new Person { Country = "Belarus"},
                            new Person { Country = "Russia"},
                            new Person { Country = "Poland"}
                        };

                        person.CollectionChanged += Persons_CollectionChanged;

                        person.Add(new Person { Country = "Ukraine" });
                        person.RemoveAt(1);
                        person[0] = new Person { Country = "Greece" };

                        foreach (Person persons in person)
                        {
                            Console.WriteLine(persons.Country);
                        }
                        Console.Write("\nPress any key to continue...");
                        Console.ReadKey();              
                        break;
                    case 0:
                        break;
                }
            } while (caseSwitch != 0);
        }

        private static void Persons_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Person newUser = e.NewItems[0] as Person;
                    Console.WriteLine("Added new object: {0}", newUser.Country);
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Person oldUser = e.OldItems[0] as Person;
                    Console.WriteLine("Deleted object: {0}", oldUser.Country);
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Person replacedUser = e.OldItems[0] as Person;
                    Person replacingUser = e.NewItems[0] as Person;
                    Console.WriteLine("Object {0} replaced by an object {1}",
                                        replacedUser.Country, replacingUser.Country);
                    break;
            }
        }
    }
}
