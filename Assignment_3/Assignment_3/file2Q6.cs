namespace Assignment_3
{
    public partial class Employee
    {
        public double CalculateRegularSalary()
        {
            return BasicSalary;
        }

        public double CalculateOvertimeSalary()
        {
            int extraHours = WorkingHours - 40; // Hours over 40 are overtime
            if (extraHours > 0)
            {
                double overtimeRate = BasicSalary / 160 * 1.5; // Assuming 160 regular hours per month
                return BasicSalary + (extraHours * overtimeRate);
            }
            return BasicSalary;
        }
    }
}