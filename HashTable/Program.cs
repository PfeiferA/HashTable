using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHashTable = new SuperHashTable<Person>(100);
            var person = new Person() { Name = "Juliy", Age = 12, Gender = 1 };
            superHashTable.Add(new Person() { Name="Olaf", Age=25,Gender=0});
            superHashTable.Add(new Person() { Name = "Tom", Age = 22, Gender = 0 });
            superHashTable.Add(new Person() { Name = "Nino", Age = 26, Gender = 1 });
            superHashTable.Add(new Person() { Name = "Maus", Age = 35, Gender = 0 });
            superHashTable.Add(person);

            Console.WriteLine(superHashTable.Search(new Person() { Name = "Tom", Age = 22, Gender = 0 }));
            Console.WriteLine(superHashTable.Search(person));


            Console.ReadLine();

            var hashTable = new HashTable<int, string>(100);
            hashTable.Add(5, "Hallo");
            hashTable.Add(18, "Bye");

            Console.WriteLine(hashTable.Search(18, "Bye"));
            Console.WriteLine(hashTable.Search(12, "Hallo"));

            Console.WriteLine();

            var badHashTable = new BadHashTable<int>(100);
            badHashTable.Add(5);
            badHashTable.Add(18);
            badHashTable.Add(5777);

            Console.WriteLine(badHashTable.Search(6));
            Console.WriteLine(badHashTable.Search(18));


            Console.ReadLine();
        }
    }
}
