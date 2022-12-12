namespace lab13
{
    [Serializable]
    public class Human : IntelligentBeing
    {
        [NonSerialized]
        public string Gender;
        
        public Human(string name, DateTime age, string gender) : base(name, age)
        {
            Gender = gender;
        }

        public override string ToString()
        {
            return $"name:{Name}\t age:{Age}\t gender:{Gender}";
        }
    }
}
