namespace StudentManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the Student class.
            Student student1 = new Student("Alice Smith", 1001, "ComputerScience");
            Student student2 = new Student("Bob Johnson", 1002, "Electrical Engineering");

            // Display information for each student.
            student1.DisplayStudentInfo();
            student2.DisplayStudentInfo();
        }

        /// <summary>
        /// Represents a student with their enrollment details.
        /// </summary>
        class Student
        {
            // Student attributes.
            string name;
            int ID;
            string major;

            /// <summary>
            /// Initializes a new instance of the Student class.
            /// </summary>
            /// <param name="name">The student's full name.</param>
            /// <param name="ID">The student's unique identification number.</param>
            /// <param name="major">The student's academic major.</param>
            public Student(string name, int ID, string major)
            {
                this.name = name;
                this.ID = ID;
                this.major = major;
            }

            /// <summary>
            /// Displays the student's information to the console.
            /// Includes name, ID, and major.
            /// </summary>
            public void DisplayStudentInfo()
            {
                Console.WriteLine("  Student Information:");
                Console.WriteLine($"  Name: {name}");
                Console.WriteLine($"  Student ID: {ID}");
                Console.WriteLine($"  Major: {major}");
                Console.WriteLine(); // Adds a blank line for readability between student info blocks.
                Console.WriteLine(); // Adds another blank line for readability.
            }
        }
    }
}

