using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People();
            people1.Age = 37;
            people1.FirstName = "Bob";
            people1.LastName = "Smith";
            people1.HairColor = "Brown";

            People people2 = new People();
            people2.Age = 38;
            people2.FirstName = "Stanley";
            people2.LastName = "Johnson";
            people2.HairColor = "Blonde";

            People people3 = new People();
            people3.Age = 39;
            people3.FirstName = "Frank";
            people3.LastName = "Crown";
            people3.HairColor = "Red";


            List<People> trueCoders = new List<People>();
            trueCoders.Add(people1);
            trueCoders.Add(people2);
            trueCoders.Add(people3);

            Console.WriteLine($"{people1.FirstName} { people1.LastName } {people1.Age} {people1.HairColor}");
            Console.WriteLine($"{people2.FirstName} { people2.LastName } {people2.Age} {people2.HairColor}");
            Console.WriteLine($"{people3.FirstName} { people3.LastName } {people3.Age} {people3.HairColor}");

            Console.ReadLine();
        }
    }
}
