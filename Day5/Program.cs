using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Employee
    {
        public int EmpNo;

        public string EmpName;

        public string Designation;

        public decimal Salary;

        public void SetData(int empNo, string empName, decimal salary)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            this.Salary = salary;
        }

        public void show()
        {
            Console.WriteLine(EmpNo);
            Console.WriteLine(EmpName);
            Console.WriteLine(Salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Of Employee = ");

            int capacity = int.Parse(Console.ReadLine());

            Employee[] e1 = new Employee[capacity];

            for (int i = 0; i < e1.Length; i++)
            {
                Console.WriteLine("Enter EmpNo = ");
                int empno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Name = ");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter salary = ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Employee temp = new Employee();
                temp.SetData(empno, empname, salary);
                e1[i] = temp;
            }

            decimal max = e1[0].Salary;
            Console.WriteLine("");
            Console.WriteLine("Highest Salary Employee");
            Console.WriteLine("");
            for (int i = 0; i < e1.Length; i++)
            {

                if (e1[i].Salary > max)
                {
                    max = e1[i].Salary;
                    e1[i].show();
                }
            }
            Console.WriteLine("");
            Console.WriteLine("\n Enter the EmpNo = ");
            Console.WriteLine("");
            int search = int.Parse(Console.ReadLine());

            for (int i = 0; i < e1.Length; i++)
            {

                if (e1[i].EmpNo == search)
                {
                    e1[i].show();
                }

            }
            Console.ReadLine();
        }
    }
}
