using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_part2
{
    using System;
    using System.Collections.Generic;

    public interface IAnimal
    {
        string Name { get; set; }
        string Colour { get; set; }
        double Height { get; set; }
        int Age { get; set; }

        string GetName();
        string GetColour();
        double GetHeight();
        int GetAge();

        void SetName(string name);
        void SetColour(string colour);
        void SetHeight(double height);
        void SetAge(int age);

        void Eat();
        string Cry();
    }

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public string GetName() { return Name; }
        public string GetColour() { return Colour; }
        public double GetHeight() { return Height; }
        public int GetAge() { return Age; }

        public void SetName(string name) { Name = name; }
        public void SetColour(string colour) { Colour = colour; }
        public void SetHeight(double height) { Height = height; }
        public void SetAge(int age) { Age = age; }

        public void Eat()
        {
            Console.WriteLine("\nDogs eat meat.");
        }

        public string Cry()
        {
            return "\nWoof!";
        }
    }

    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public string GetName() { return Name; }
        public string GetColour() { return Colour; }
        public double GetHeight() { return Height; }
        public int GetAge() { return Age; }

        public void SetName(string name) { Name = name; }
        public void SetColour(string colour) { Colour = colour; }
        public void SetHeight(double height) { Height = height; }
        public void SetAge(int age) { Age = age; }

        public void Eat()
        {
            Console.WriteLine("\nCats eat mice.");
        }

        public string Cry()
        {
            return "\nMeow!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter dog's name:");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(dogName);

            Console.WriteLine("\nEnter dog's height:");
            double dogHeight = double.Parse(Console.ReadLine());
            dog.SetHeight(dogHeight);

            Console.WriteLine("\nEnter dog's colour:");
            dog.SetColour(Console.ReadLine());

            Console.WriteLine("\nEnter dog's age:");
            int dogAge = int.Parse(Console.ReadLine());
            dog.SetAge(dogAge);

            Console.WriteLine($"\nDog Name: {dog.GetName()}");
            Console.WriteLine($"\nHeight: {dog.GetHeight()}");
            Console.WriteLine($"\nColour: {dog.GetColour()}");
            Console.WriteLine($"\nAge: {dog.GetAge()}");

                dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("\nEnter cat's name:");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.SetName(catName);

            Console.WriteLine("\nEnter cat's height:");
            double catHeight = double.Parse(Console.ReadLine());
            cat.SetHeight(catHeight);

            Console.WriteLine("\nEnter cat's colour:");
            cat.SetColour(Console.ReadLine());

            Console.WriteLine("\nEnter cat's age:");
            int catAge = int.Parse(Console.ReadLine());
            cat.SetAge(catAge);

            Console.WriteLine($"\nCat Name: {cat.GetName()}");
            Console.WriteLine($"\n Height: {cat.GetHeight()}");
            Console.WriteLine($"\nColour: {cat.GetColour()}");
            Console.WriteLine($"\n Age: {cat.GetAge()}");


            cat.Eat();
            Console.WriteLine(cat.Cry());

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            Console.WriteLine("\nNames of all the animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
            Console.ReadLine(); 
        }
    }

}
