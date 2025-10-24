using System;
using System.Collections.Generic;

namespace Assignment_2
{
    //Q1:###########################################################################

    class UserProfile
    {
        private string username = "";
        private string password;
        private string email;

        internal void set(string username, string password, string email)
        {
            this.username = username;
            validatePassword(password);
            validateEmail(email);
        }
        internal void get()
        {
            Console.WriteLine(this.username + " " + this.password + " " + this.email);
        }
        internal void validateEmail(string email)
        {
            if (email == null)
            {
                Console.WriteLine("email is empty");
                return;
            }
            else if (!email.Contains("@"))
            {
                Console.WriteLine("email is not valid");
                return;
            }
            else
            {
                this.email = email;
            }
        }
        internal void validatePassword(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("password is invalid");
                return;
            }
            this.password = password;
        }
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile();
            profile.set("john_doe", "securePass123", "john.doe@example.com");
            profile.get();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q2:###########################################################################

    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
    class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        public Truck(string make, string model, int year, int loadCapacity) : base(make, model, year)
        {
            LoadCapacity = loadCapacity;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Truck: " + Year + " " + Make + " " + Model + ", Load Capacity: " + LoadCapacity);
        }
    }
    class Bus : Vehicle
    {
        public int SeatingCapacity { get; set; }
        public Bus(string make, string model, int year, int seatingCapacity) : base(make, model, year)
        {
            SeatingCapacity = seatingCapacity;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Bus: " + Year + " " + Make + " " + Model + ", Seating Capacity: " + SeatingCapacity);
        }
    }
    class Q2
    {
        static void Main(string[] args)
        {
            Truck truck1 = new Truck("Ford", "F-150", 2023, 3000);
            Bus bus1 = new Bus("Bluebird", "Vision", 2022, 72);
            truck1.DisplayDetails();
            bus1.DisplayDetails();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q3:###########################################################################

    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }
    }
    class Q3
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("int, int: " + calc.Add(15, 25));
            Console.WriteLine("int, int, int: " + calc.Add(4, 5, 6));
            Console.WriteLine("float, float: " + calc.Add(3.5f, 4.5f));
            Console.WriteLine("double, double: " + calc.Add(7.5, 8.5));
            Console.WriteLine("double, double, double: " + calc.Add(2.2, 3.3, 4.4));
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q4:###########################################################################

    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }
        public abstract double CalculateSalary();
    }
    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, double monthlySalary) : base(name)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    class Q4
    {
        static void Main(string[] args)
        {
            FullTimeEmployee emp1 = new FullTimeEmployee("Sophia", 60000);
            Console.WriteLine(emp1.Name + "'s Salary = " + emp1.CalculateSalary());
            PartTimeEmployee emp2 = new PartTimeEmployee("James", 200, 80);
        }
    }


    //Q5:###########################################################################

    class Student
    {
        private string name;
        private int rollNumber;
        private double marks;
        public Student()
        {
            name = "Unknown";
            rollNumber = 0;
            marks = 0.0;
        }
        public Student(string name, int rollNumber)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.marks = 0.0;
        }
        public Student(string name, int rollNumber, double marks)
        {
            this.name = name;
            this.rollNumber = rollNumber;
            this.marks = marks;
        }
        public void DisplayData()
        {
            Console.WriteLine("Name: " + name + ", Roll No: " + rollNumber + ", Marks: " + marks);
        }
    }
    class Q5
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student("Emma", 201);
            Student s3 = new Student("Liam", 202, 95.0);

            Console.WriteLine("Student Records:");
            s1.DisplayData();
            s2.DisplayData();
            s3.DisplayData();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q6:###########################################################################

    class Product
    {
        private int productID;
        private string productName;
        private double price;
        private int quantity;
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Invalid price. Price cannot be negative.");
            }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
                else
                    Console.WriteLine("Invalid quantity. Quantity cannot be negative.");
            }
        }
        public void PrintDetails()
        {
            Console.WriteLine("ProductID: " + ProductID + ", Name: " + ProductName + ", Price: " + Price + ", Quantity: " + Quantity);
        }
    }
    class Q6
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ProductID = 202;
            p1.ProductName = "Smartphone";
            p1.Price = 30000;
            p1.Quantity = 50;
            p1.PrintDetails();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }


    //Q7:###########################################################################

    class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; } = true;
        public virtual void Display()
        {
            Console.WriteLine("BookID: " + BookID + ", Title: " + Title + ", Author: " + Author + ", Available: " + IsAvailable);
        }
    }
    class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
        public virtual void Display()
        {
            Console.WriteLine("MemberID: " + MemberID + ", Name: " + Name + ", Borrowed Books: " + BorrowedBooks.Count);
        }
    }
    class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book b)
        {
            books.Add(b);
        }
        public void RegisterMember(Member m)
        {
            members.Add(m);
        }
        public void LendBook(int bookID, int memberID)
        {
            Book book = books.Find(b => b.BookID == bookID && b.IsAvailable);
            Member member = members.Find(m => m.MemberID == memberID);
            if (book != null && member != null)
            {
                book.IsAvailable = false;
                member.BorrowedBooks.Add(book);
                Console.WriteLine(member.Name + " borrowed " + book.Title);
            }
            else
            {
                Console.WriteLine("Book not available or Member not found");
            }
        }
        public void DisplayAvailableBooks()
        {
            Console.WriteLine("Available Books:");
            foreach (Book b in books)
            {
                if (b.IsAvailable)
                    b.Display();
            }
        }
    }
    class Q7
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book b1 = new Book { BookID = 3, Title = "Data Structures", Author = "Alice Johnson" };
            Book b2 = new Book { BookID = 4, Title = "Algorithms", Author = "Bob Brown" };
            library.AddBook(b1);
            library.AddBook(b2);

            Member m1 = new Member { MemberID = 201, Name = "Charlie" };
            Member m2 = new Member { MemberID = 202, Name = "Diana" };
            library.RegisterMember(m1);
            library.RegisterMember(m2);

            library.DisplayAvailableBooks();
            library.LendBook(3, 201);
            library.DisplayAvailableBooks();
            Console.WriteLine("\nDeveloped by: Kuldeep Singh (MCA 2nd Year - Sec C)\nRoll No: 2484200103");
        }
    }
}
