using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    public class StudentData
    {
        public int StdNo;
        public string StdName;
        public decimal StdMarks;
        public void setvalues(int Rno, string Sname, decimal Marks)
        {
            this.StdNo = Rno;
            this.StdName = Sname;
            this.StdMarks = Marks;
        }

        public void show()
        {
            Console.WriteLine(StdNo);
            Console.WriteLine(StdName
                );
            Console.WriteLine(StdMarks);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Of Students =");
            int capacity = int.Parse(Console.ReadLine());
            StudentData[] e1 = new StudentData[capacity];

            for (int i = 0; i < e1.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Roll no = ");
                int Rno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name = ");
                string Sname = Console.ReadLine();
                Console.WriteLine("Enter Marks = ");
                decimal Marks = decimal.Parse(Console.ReadLine());
                StudentData temp = new StudentData();
                temp.setvalues(Rno, Sname, Marks);
                e1[i] = temp;
            }
            Console.WriteLine("");
            Console.WriteLine("Enter the Student RollNo ");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < e1.Length; i++)
            {
                if (e1[i].StdNo == search)
                {
                    e1[i].show();
                }
            }
            Console.ReadLine();
        }
    }
}
