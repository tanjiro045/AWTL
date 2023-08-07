namespace P3Overriding
{
    public class Student
    {
        public int id, grade, age;
        public string name, address;
        public void getData()
        {
            Console.WriteLine("Enter ID:");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter Grade:");
            grade = Int32.Parse(Console.ReadLine());
        }
        public void displayData()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Grade: " + grade);
        }
        public virtual Boolean IsPassed()
        {
            return true;
        }
    }
    public class Graduate : Student
    {
        public override bool IsPassed()
        {
            if (grade >= 80 && grade <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class Undergraduate : Student
    {
        public override bool IsPassed()
        {
            if (grade >= 70 && grade <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Graduate g = new Graduate();
            g.getData();
            g.displayData();
            g.IsPassed();
            if (g.IsPassed() == true)
            {
                Console.WriteLine("Passed in Graduation.");
            }
            else
            {
                Console.WriteLine("Failed in Graduation.");
            }
            Undergraduate ug = new Undergraduate();
            ug.getData();
            ug.displayData();
            ug.IsPassed();
            if (ug.IsPassed() == true)
            {
                Console.WriteLine("Passed in UnderGraduation.");
            }
            else
            {
                Console.WriteLine("Failed in UnderGraduation.");
            }
            Console.ReadLine();
        }
    }
}