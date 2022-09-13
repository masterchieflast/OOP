namespace lab02
{
    public partial class Student
    {
        public static int _idCounter;
        public const string University = "BSTU";
        private readonly int Id;
        private string Name { get; set; }
        private string LastName { get; }
        private string MiddleName { get; set; }
        private DateTime Birthday { get; set; }
        private string City { get; set; }

        private string PhoneNumber { get; set; }

        private string faculty = "";
        private string Faculty
        {
            get => faculty;
            set
            {
                if (value.ToLower() != "fit"
                    && value.ToLower() != "htit")
                {
                    throw new Exception();
                }

                faculty = value;
            }
        }
        
        private int Course { get; set; }
        private int Group { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            const int size = 3;
            var students = new Student[size];
            students[0] = new Student("Vanya", "Stepanov", new DateTime(2004, 10, 9), "+375298467777", "HTIT");
            students[1] = new Student("Stepa", "Ivanov", "Pichkov", new DateTime(2004, 5, 16), "Minsk", "+375298467778", "fit", 2, 3);
            students[2] = new Student("+375298467777", "fit");

            var listStudent = new List<Student>();
            for (var i = 0; i < size; i++)
            {
                Console.WriteLine($"student {i}:");
                listStudent.Add(students[i]);
                Console.WriteLine("age: " + students[i].AgeСalculation());

                var countCourse = 0;
                students[i].CourseRemained(out var countCourseRemained, ref countCourse);
                Console.WriteLine("countCourse: " + Convert.ToString(countCourse));
                Console.WriteLine("CourseRemained: " + Convert.ToString(countCourseRemained));
                Console.WriteLine();
            }


            var studentFromFit = Student.FacultyList(listStudent, "fit");
            foreach (var student in studentFromFit)
            {
                Console.WriteLine(student.ToString());
            }

            var studentFromFitAndGroup = Student.FacultyAndGroupList(listStudent, "fit", 3);
            foreach (var student in studentFromFitAndGroup)
            {
                Console.WriteLine(student.ToString());
            }

            var anonStudent = new Student("Stepa", "Ivanov", "Pichkov", new DateTime(2004, 5, 16), "Minsk", "+375298467778", "fit", 2, 3);
            var anonStudent2 = new Student("Stepa", "Ivanov!!!!", "Pichkov", new DateTime(2004, 5, 16), "Minsk", "+375298467778", "fit", 2, 3);
            Console.WriteLine(anonStudent.Equals(students[1]));
            Console.WriteLine(anonStudent2.Equals(students[1]));
        }
    }
}