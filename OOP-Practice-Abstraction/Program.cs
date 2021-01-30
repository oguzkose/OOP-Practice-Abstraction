using System;

namespace OOP_Practice_Abstraction
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string WorkingHours { get; set; }

        public int standartSalary = 3000;
        public abstract int SalaryCalculation();
    }

    class FullTimeEmployee : Employee
    {
        
        public override int SalaryCalculation()
        {
            int salary = standartSalary;
            return Convert.ToInt32(salary + (salary * 2.50));
        }
    }
    class PartTimeEmployee : Employee
    {
        public override int SalaryCalculation()
        {
            int salary = standartSalary;
            return Convert.ToInt32(salary + (salary * 1.10));
        }
    }
    /// <summary>
    ///  1=> Abstract(Soyut) Class'lar imza niteliği taşır.
    ///  2=> Abstract olarak işaretlenmiş elemanları, kendisine üye Derived Class'larına implenent edilmek zorundadır.
    ///  3=> Abstract Class'ların Instance'si alınamaz.(RAM'da bir öreneği yaratılamaz)
    ///  5=> Ancak Abstract Class, Derived Class'ı refere edebilir. 
    ///  6=> Abstract Class'ların içinde bulunan metotların gövdeleri yazılmaz.(Gövdeleri, implemente edildikten sonra Derived Class'ta yazılır)
    ///  7=> Abstract Class'ların içinde bulunan Metotların ,Field'ların , Property'lerin Erişim Belirleyicisi Public veya Protected olmak zorundadır.
    ///  
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
                   

            //Employee fte = new FullTimeEmployee();
            FullTimeEmployee fte = new FullTimeEmployee();

            fte.Id = 1;
            fte.FullName = "John Doe";
            fte.Department = "IT";
            fte.WorkingHours = "Full-Time";
            fte.SalaryCalculation();

            PartTimeEmployee pte = new PartTimeEmployee();

            pte.Id = 2;
            pte.FullName = "Jane Doe";
            pte.Department = "IT";
            pte.WorkingHours = "Part-Time";
            pte.SalaryCalculation();


            Console.WriteLine("Employee ID: " + fte.Id + "\n" + "Employee Name: " + fte.FullName + "\n" + "Department: " + fte.Department + "\n"+ "Working Hours: " + fte.WorkingHours + "\n" + "Salary: " + fte.SalaryCalculation() + "$" + "\n" +"\n"+"Employee ID: " + pte.Id + "\n" + "Employee Name: " + pte.FullName + "\n" + "Department: " + pte.Department + "\n" + "Working Hours: "+ pte.WorkingHours+ "\n"+ "Salary: " + pte.SalaryCalculation() + "$");

        }
    }
}

