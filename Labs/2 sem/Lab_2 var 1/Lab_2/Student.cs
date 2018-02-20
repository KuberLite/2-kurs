
using System;

namespace Lab_2
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Otchestvo { get; set; }
        public string Date_birthday { get; set; }
        public string Spec { get; set; }
        public string Course { get; set; }
        public string Group { get; set; }
        public string Average_mark { get; set; }
        public string Sex { get; set; }

        public Adress Adress { get; set; }
        public CurrentWork CurrentWork { get; set; }

        public Student()
        {
        }
    }
}