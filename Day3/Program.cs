using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    #region main
    class Program
    {
        static void Main(string[] args)
        {
            Employee o = new Manager();
            Console.WriteLine(o.CalcNetSalary());

            Employee o1 = new GeneralManager();
            Console.WriteLine(o1.CalcNetSalary());

            Employee o2 = new CEO();
            Console.WriteLine(o2.CalcNetSalary());

            Console.ReadLine();

        }
    }
    #endregion

    #region EmployeeClass
    public abstract class Employee
    {
        public decimal gross_salary;
        public decimal da;
        public decimal hra;
        private static int hold;

        private int empNo;
        public int EmpNo
        {
            get;
        }

        protected short deptNo;
        public short DeptNo
        {
            get { return deptNo; }
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    deptNo = 10;
            }
        }

        protected string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    name = value;
                else
                    name = "NoName";
            }
        }

        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }

        public Employee(string Name = "noname", decimal Basic = 10000, short DeptNo = 10)
        {
            empNo = ++hold;
            this.Name = Name;
            this.Basic = Basic;
            this.DeptNo = DeptNo;
        }

        public abstract decimal CalcNetSalary();
    }
    #endregion

    #region ManagerClass
    public class Manager : Employee
    {
        public override decimal Basic
        {
            get { return basic; }
            set 
            {
                if (value > 20000)
                    basic = value;
                else
                    basic = 20000;
            }
        }

        private string designation;
        public string Designation
        {
            set 
            {
                if(value == null)
                    designation = value;
                else
                    designation = value; 
            }
            get { return designation; }
        }

        public Manager(string Name = "noname", decimal Basic = 10000, short DeptNo = 10, string Designation="GM") : base(Name, Basic, DeptNo)
        {
            this.designation = Designation;
        }

        public override decimal CalcNetSalary()
        {
            gross_salary = Basic + da + hra;
            return gross_salary;
        }
    }
    #endregion

    #region GeneralManagerClass
    public class GeneralManager : Manager
    {
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 40000)
                    basic = value;
                else
                    basic = 40000;
            }
        }

        public string perks;

        public string Perks
        {
            get { return perks; }
            set { perks = value; }
        }
        public GeneralManager(string Name = "noname", decimal Basic = 10000, short DeptNo = 10, string Designation = "GM", string Perks="none") : base(Name, Basic, DeptNo, Designation)
        {
            this.perks = Perks;
        }
        public override decimal CalcNetSalary()
        {
            gross_salary = Basic + da + hra;
            return gross_salary;
        }
    }
    #endregion

    #region CEOClass
    public class CEO : Employee
    {
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 100000)
                    basic = value;
                else
                    basic = 100000;
            }
        }
        
        public CEO(string Name = "noname", decimal Basic = 100000, short DeptNo = 10) : base(Name, Basic, DeptNo)
        {
           
        }

        public sealed override decimal CalcNetSalary()
        {
            gross_salary = Basic + da + hra;
            return gross_salary;
        }
    }
    #endregion
}