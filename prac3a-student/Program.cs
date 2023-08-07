using System;
namespace P3MultiLevelInheritance
{
    public class Student
    {
        int rollno;
        string name;
        public void getStudentData()
        {
            Console.WriteLine("Enter Roll No:");
            rollno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
        }
        public void displayStudentData()
        {
            Console.WriteLine("Roll No: " + rollno);
            Console.WriteLine("Name: " + name);
        }
    }
    public class Test : Student
    {
        public int marks1, marks2;
        public void getMarks()
        {
            getStudentData();
            Console.WriteLine("Enter Marks 1 out of 100:");
            marks1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks 2 out of 100:");
            marks2 = Int32.Parse(Console.ReadLine());
        }
        public void setMarks()
        {
            displayStudentData();
            Console.WriteLine("Marks1: " + marks1);
            Console.WriteLine("Marks2: " + marks2);
        }
    }
    public class Result : Test
    {
        int calc;
        public void getCalc()
        {
            getMarks();
            calc = marks1 + marks2;
            setMarks();
            Console.WriteLine("Total Marks Out of 200: " + calc);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result r = new Result();
            r.getCalc();
            Console.ReadLine();
        }
    }
}
