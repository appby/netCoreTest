using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        class Person
        {
            public string name { get; set; }
            public int year { get; set; }

            public string WriteResult(){
                return $"Ad: {this.name}\nYaş: {this.calculateAge()}";
            }

            public int calculateAge()
            {
                return DateTime.Now.Year - this.year;
            }

        }
        static void Main(string[] args)
        {
            var p1 = new Person() { name = "Micheal", year = 1990};
            Console.WriteLine(p1.WriteResult());

        }
    }
}