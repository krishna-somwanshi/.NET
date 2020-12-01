using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("Amol", 123465, 10);
            Employee o2 = new Employee("Amol", 123465);
            Employee o3 = new Employee("Amol");
            Employee o4 = new Employee();

            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o3.EmpNo);
         
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);  

            Console.ReadLine();

        }
        public class Employee
        {
            public string Name;
            public int EmpNo;
            public static int hold;
            public decimal Basic;
            public short DeptNo;
            public decimal gross_salary;
            public decimal da;
            public decimal hra;

            public Employee()
            {
                hold += 1;
                EmpNo = hold;
            }

            public Employee(string cName)
            {
                this.Name = cName;
                hold += 1;
                EmpNo = hold;
            }
            public Employee(string cName, int cBasic)
            {
                this.Name = cName;
                hold += 1;
                EmpNo = hold;
                this.Basic = cBasic;
            }
            public Employee(string cName, decimal cBasic, short cDeptNo)
            {
                this.Name = cName;
                hold += 1;
                EmpNo = hold;
                this.Basic = cBasic;
                this.DeptNo = cDeptNo;
            }

            public decimal GetNetSalary()
            {
                gross_salary = Basic + da + hra;
                return gross_salary;
            }

        }
    }
}