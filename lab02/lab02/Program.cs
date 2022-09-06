namespace lab02
{
    public class Student
    {
        private int id;
        private string name;
        private string lastName;
        private string middleName;
        private DateTime birthday;
        private string city;
        private string phoneNumber;
        private string faculty;
        private int course;
        private int group;

        public int ageСalculation()
        {
            var now = DateTime.Today;
            return now.Year - birthday.Year +
                   (now.Month > birthday.Month 
                    || (now.Month == birthday.Month 
                    && now.Day >= birthday.Day) ? 0 : -1);
        }
    }

    public class Program
    {
        public static void Main()
        {
        }

    }
}