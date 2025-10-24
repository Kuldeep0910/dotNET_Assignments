using System;
using System.Collections.Generic;

namespace Assignment_3
{
    //Q1.#################################################################################

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age + ", Salary: " + Salary);
        }
    }
    class Q1
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Name = "aman", Age = 23, Salary = 50000 };
            emp1.DisplayDetails();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q2.#################################################################################

    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accNo, string holder, double initialBalance)
        {
            AccountNumber = accNo;
            AccountHolderName = holder;
            Balance = initialBalance;
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
            else
                Console.WriteLine("Deposit amount must be positive");
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal amount");
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + AccountNumber + ", Holder: " + AccountHolderName + ", Balance: " + Balance);
        }
    }
    class Q2
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(1001, "aman", 5000);
            BankAccount acc2 = new BankAccount(1002, "ankit", 3000);

            acc1.Deposit(2000);
            acc1.Withdraw(1500);
            acc1.DisplayDetails();
            acc2.DisplayDetails();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q3.#################################################################################
    
    static class MathHelp
    {
        public static double CalculateAvg(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return (double)sum / numbers.Length;
        }
    }
    class Q3
    {
        static void Main(string[] args)
        {
            int[] data = { 10, 20, 30, 40, 50 };
            double avg = MathHelp.CalculateAvg(data);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q4.#################################################################################
    
    static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine("[LOG] " + message);
        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Application started.");
            Logger.LogMessage("Performing some operations...");
            Logger.LogMessage("Application ended.");
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q5.#################################################################################

    class Q5
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };
            person.PrintFullName();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q6.#################################################################################

    class Q6
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                Id = 101,
                Name = "John Smith",
                BasicSalary = 50000,
                WorkingHours = 45
            };
            Console.WriteLine($"Employee: {emp.Name}");
            Console.WriteLine($"Regular Salary: {emp.CalculateRegularSalary():C}");
            Console.WriteLine($"Salary with Overtime: {emp.CalculateOvertimeSalary():C}");
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q7.#################################################################################
    
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
    class Q7
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);
            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q8.#################################################################################

    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void MakeSound();

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} years");
        }
    }

    class Dog : Animal
    {
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }

    class Cat : Animal
    {
        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing the tree!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }

    class Q8
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog { Name = "Buddy", Age = 3 };
            Cat cat = new Cat { Name = "Whiskers", Age = 2 };

            Console.WriteLine("=== Animal Information ===");

            dog.DisplayInfo();
            dog.MakeSound();
            dog.Fetch();

            Console.WriteLine();

            cat.DisplayInfo();
            cat.MakeSound();
            cat.Climb();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q9.#################################################################################

    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle engine started.");
        }
        public virtual void StopEngine()
        {
            Console.WriteLine("Vehicle engine stopped.");
        }
    }
    
    sealed class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started. Vroom!");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
        public void Honk()
        {
            Console.WriteLine("Car says: Beep Beep!");
        }
    }

    class Q9
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.StartEngine();
            v.StopEngine();

            Console.WriteLine();

            Car c = new Car();
            c.StartEngine();
            c.Honk();
            c.StopEngine();

            Console.WriteLine();
            Console.WriteLine("Note: Attempting to inherit from 'Car' will fail because it is sealed (compile-time error).");
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q10.#################################################################################

    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; protected set; }

        public BankAccount(int accNo, string holder, double initialBalance)
        {
            AccountNumber = accNo;
            AccountHolder = holder;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0) Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance:C}");
        }
    }

    sealed class SavingsAccount : BankAccount
    {
        // Annual interest rate in percent (e.g., 5 for 5%)
        public double InterestRate { get; set; }

        public SavingsAccount(int accNo, string holder, double initialBalance, double interestRate)
            : base(accNo, holder, initialBalance)
        {
            InterestRate = interestRate;
        }

        // Calculate interest for one year (simple interest based on current balance)
        public double CalculateAnnualInterest()
        {
            return Balance * (InterestRate / 100.0);
        }

        // Apply the calculated annual interest to the balance
        public void ApplyAnnualInterest()
        {
            double interest = CalculateAnnualInterest();
            Balance += interest;
        }
    }

    class Q10
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount(2001, "Aman", 10000, 5); // 5% annual interest
            sa.DisplayDetails();
            Console.WriteLine($"Annual Interest: {sa.CalculateAnnualInterest():C}");
            sa.ApplyAnnualInterest();
            Console.WriteLine("After applying interest:");
            sa.DisplayDetails();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
}
