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

    public interface IDFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    #region EmployeeClass
    public abstract class Employee : IDFunctions
    {
        protected decimal gross_salary;
        protected decimal da;
        protected decimal hra;
        private static int hold;

        private int empNo;
        public int EmpNo
        {
            get;
        }

        private short deptNo;
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

        private string name;
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

        public void Delete()
        {
            Console.WriteLine("Employee - IDb.Delete");
        }
        public void Insert()
        {
            Console.WriteLine("Employee - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee - IDb.Update");
        }
    }
    #endregion

    #region ManagerClass
    public class Manager : Employee, IDFunctions
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
        public void Delete()
        {
            Console.WriteLine("Manager - IDb.Delete");
        }
        public void Insert()
        {
            Console.WriteLine("Manager - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("Manager - IDb.Update");
        }
    }
    #endregion

    #region GeneralManagerClass
    public class GeneralManager : Manager, IDFunctions
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
        public void Delete()
        {
            Console.WriteLine("GeneralManager - IDb.Delete");
        }
        public void Insert()
        {
            Console.WriteLine("GeneralManager - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("GeneralManager - IDb.Update");
        }
    }
    #endregion

    #region CEOClass
    public class CEO : Employee, IDFunctions
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

        public void Delete()
        {
            Console.WriteLine("CEO - IDb.Delete");
        }
        public void Insert()
        {
            Console.WriteLine("CEO - IDb.Insert");
        }

        public void Update()
        {
            Console.WriteLine("CEO - IDb.Update");
        }
    }
    #endregion
}