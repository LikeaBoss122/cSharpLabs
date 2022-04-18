using System;
using System.Diagnostics;

namespace Lab2
{
    public static class Program
    {
        static void Main(string[] agrs)
        {
            Person person = new Person() { Birthday = new DateTime(1)};
            Person person1 = new Person() { Birthday = new DateTime(1)};
            Person person2 = null;

            Console.WriteLine($"p1 == p {person1 == person}");
            Console.WriteLine($"p2 == null {person2 == null}");
            Console.WriteLine($"p1 equals p {person1.Equals(person)}");

        }
    }
}
