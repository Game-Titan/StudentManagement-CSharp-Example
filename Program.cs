using System.Data;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace CODEMONKEY_LEARNING
{
    internal class Program
    {

        static void Main(string[] args)
        {
         
            Student student1 = new Student("Alice Smith", 1001, "ComputerScience");
            Student student2 = new Student("Bob Johnson", 1002, "Electrical Engineering");
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();


        }
        class Student
        {
            string name;
            int ID;
            string major;
            public Student(string name, int ID, string major)
            {
                this.name = name;
                this.ID = ID;
                this.major = major;
            }

            public void DisplayStudentInfo()
            {
                Console.WriteLine("  Student Information:");
                Console.WriteLine($"  Name: {name}");
                Console.WriteLine($"  Student ID: {ID}");
                Console.WriteLine($"  Major: {major}");
                Console.WriteLine();
                Console.WriteLine();

            }
        }
    }
}








