using System;
class Staff
{
public string name;
public string post;
public Staff(string name, string post)
{
this.name = name;
this.post = post;
}
}
class Program
{
static void Main(string[] args)
{
Staff[] staffs = new Staff[5];
for (int i = 0; i < 5; i++)
{
Console.Write("Enter name for staff {0}: ", i + 1);
string name = Console.ReadLine();
Console.Write("Enter post for staff {0}: ", i + 1);
string post = Console.ReadLine();
staffs[i] = new Staff(name, post);
}
Console.WriteLine("\n");
Console.WriteLine("HOD staffs:");
Console.WriteLine("\n");
foreach (Staff staff in staffs)
{
if (staff.post == "HOD" || staff.post == "hod"){
  Console.WriteLine(staff.name);
}
  Console.ReadKey();
}
}
