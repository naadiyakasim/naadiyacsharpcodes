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

        // Constructor
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Public properties
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

        // Method to display student info
        public void DisplayInfo()
        {
            Console.WriteLine($"\nStudent Name: {name}, Age: {age}");
        }
    }

    // 🚗 Car class
    class Car
    {
        // Private fields
        private string model;
        private string color;

        // Constructor
        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        // Public properties
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

        // Method to display car info
        public void DisplayInfo()
        {
            Console.WriteLine($"\nCar Model: {model}, Color: {color}");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student object
            Student student1 = new Student("Aisha", 20);
            student1.DisplayInfo();
            student1.Age = 22; // Changing properties using encapsulation
            Console.WriteLine("\nAfter updating values:");
            student1.DisplayInfo();

            // Create Car object
            Car car1 = new Car("Toyota", "Red");
            car1.DisplayInfo();
            car1.Color = "Blue";
            Console.WriteLine("\nAfter updating values:");
            car1.DisplayInfo();
            


        }
    }
}
