using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaadiyasCSApp
{
    class Student
    {
        // Private fields (encapsulation)
        private string name;
        private int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 100)
                    age = value;
                else
                    Console.WriteLine("Invalid age.");
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\nStudent Name: {name}, Age: {age}");
        }
    }

    class Car
    {
        private string model;
        private string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nCar Model: {model}, Color: {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Aisha", 20);
            student1.DisplayInfo();
            student1.Age = 22; // Changing properties using oops - encapsulation
            Console.WriteLine("\nAfter updating values:");
            student1.DisplayInfo();

            Car car1 = new Car("Toyota", "Red");
            car1.DisplayInfo();
            car1.Color = "Blue";
            Console.WriteLine("\nAfter updating values:");
            car1.DisplayInfo();
            


        }
    }
}
