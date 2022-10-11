namespace laba05
{
    public class IntelligentBeing : object
    {
        public string Name;


        public readonly DateTime Birthday;
        public TimeSpan Age => DateTime.Now.Subtract(Birthday) / 365;

        public IntelligentBeing(string name, DateTime birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"this creature:{Name}\t live:{Age} year";
        }
    }
}
