namespace laba04
{
    public class Human : IntelligentBeing
    {
        public string? Gender;

        public Human(string name, int age) : base(name, age) { }

        public Human(string name, int age, string gender) : base(name, age)
        {
            Gender = gender;
        }

        public override string ToString()
        {
            return $"name:{Name}\t age:{Age}\t gender:{Gender}";
        }
    }
}
