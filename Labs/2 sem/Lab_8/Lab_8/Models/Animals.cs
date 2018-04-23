using Lab_8.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_8
{
    public class Animals
    {
        public int Id { get; set; }

        public string nameAnimal { get; set; }

        public string classAnimal { get; set; }

        public int age { get; set; }

        public List<Zoo> Zoo { get; set; }
    }
}