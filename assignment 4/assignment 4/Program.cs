using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment 4
{
    //Q1.###########################################################################
    
    class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value > balance)
                    balance = value;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient balance.");
        }
    }
    class Q1
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Balance = 1000;
            Console.WriteLine("After deposit: " + account.Balance);
            account.Withdraw(500);
            Console.WriteLine("After withdrawal: " + account.Balance);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q2.###########################################################################

    class Student
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 25)
                    age = value;
                else
                    age = 18;
            }
        }
    }
    class Q2
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Age = 4 };
            Student s2 = new Student() { Age = 20 };
            Student s3 = new Student() { Age = 30 };

            Console.WriteLine("Age set to 4 → " + s1.Age);
            Console.WriteLine("Age set to 20 → " + s2.Age);
            Console.WriteLine("Age set to 30 → " + s3.Age);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q3.###########################################################################

    class Employee
    {
        private double basicSalary;
        public double BasicSalary
        {
            set { basicSalary = value; }
        }
        public double TotalSalary
        {
            get { return basicSalary * 1.2; }
        }
    }
    class Q3
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.BasicSalary = 30000;
            Console.WriteLine("Total Salary: " + emp.TotalSalary);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q4.###########################################################################
    
    class Product
    {
        public double Price { get; set; }
        public double Discount { get; set; }

        public double FinalPrice()
        {
            return Price - (Price * Discount / 100);
        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            Product prod = new Product() { Price = 2000, Discount = 10 };
            Console.WriteLine("Final Price: " + prod.FinalPrice());
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q5.###########################################################################
    
    class Car
    {
        private double speed;
        public double Speed
        {
            get { return speed; }
            set
            {
                if (value > 180)
                    speed = 180;
                else
                    speed = value;
            }
        }
    }
    class Q5
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 150;
            Console.WriteLine("Speed set to 150 → " + car.Speed);
            car.Speed = 200;
            Console.WriteLine("Speed set to 200 → " + car.Speed);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q6.###########################################################################
    
    delegate double Operation(double x, double y);
    class Q6
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Operation addOp = Add;
            Operation subOp = Subtract;

            Console.WriteLine("Addition: " + addOp(num1, num2));
            Console.WriteLine("Subtraction: " + subOp(num1, num2));
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
    

    //Q7:###########################################################################

    delegate string FormatText(string text);
    class Q7
    {
        static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
        static string ToLowerCase(string text)
        {
            return text.ToLower();
        }

        static void Main(string[] args)
        {
            string input = "Hello World";

            FormatText upperCase = ToUpperCase;
            FormatText lowerCase = ToLowerCase;

            Console.WriteLine("Original text: " + input);
            Console.WriteLine("Uppercase: " + upperCase(input));
            Console.WriteLine("Lowercase: " + lowerCase(input));
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q8:###########################################################################

    delegate void BillingOperation(double amount);
    class Q8
    {
        static void ShowTotal(double amount)
        {
            Console.WriteLine($"Original Price: ₹{amount}");
        }
        static void ApplyDiscount(double amount)
        {
            double discountedPrice = amount * 0.9;
            Console.WriteLine($"Price after 10% discount: ₹{discountedPrice}");
        }

        static void AddTax(double amount)
        {
            double discountedPrice = amount * 0.9;
            double priceWithTax = discountedPrice * 1.18;
            Console.WriteLine($"Price after 18% GST: ₹{priceWithTax}");
        }

        static void FinalBill(double amount)
        {
            double discountedPrice = amount * 0.9;
            double finalAmount = discountedPrice * 1.18;
            Console.WriteLine($"Final Payable Amount: ₹{finalAmount}");
        }

        static void Main(string[] args)
        {
            double itemPrice = 5000;

            BillingOperation billingProcess = ShowTotal;
            billingProcess += ApplyDiscount;
            billingProcess += AddTax;
            billingProcess += FinalBill;

            Console.WriteLine("=== Billing Details ===");
            billingProcess(itemPrice);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q9:###########################################################################

    delegate double ConvertTemperature(double celsius);
    class Q9
    {
        static double C2F(double celsius)
        {
            return (celsius * 9/5) + 32;
        }

        static double C2K(double celsius)
        {
            return celsius + 273.15;
        }

        static void Main(string[] args)
        {
            double tempCelsius = 25;
            ConvertTemperature toFahrenheit = C2F;
            ConvertTemperature toKelvin = C2K;
            Console.WriteLine($"Temperature: {tempCelsius}°C");
            Console.WriteLine($"In Fahrenheit: {toFahrenheit(tempCelsius)}°F");
            Console.WriteLine($"In Kelvin: {toKelvin(tempCelsius)}K");
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }

    //Q10:###########################################################################

    delegate void Notifier(string message);
    class Q10
    {
        static void SendEmail(string message)
        {
            Console.WriteLine($"EMAIL: {message}");
            Console.WriteLine("Email sent to: demo@glauniversity.com");
            Console.WriteLine("------------------------");
        }
        static void SendSMS(string message)
        {
            Console.WriteLine($"SMS: {message}");
            Console.WriteLine("SMS sent to: 2492339568");
            Console.WriteLine("------------------------");
        }

        static void Main(string[] args)
        {
            string notification = "Assignment Submitted Successfully";
            Notifier notify = SendEmail;
            notify += SendSMS;
            Console.WriteLine("=== Sending Notifications ===");
            notify(notification);
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
}
