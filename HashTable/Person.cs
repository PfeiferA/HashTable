﻿using System;


namespace HashTable
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
