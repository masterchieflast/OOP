﻿namespace lab13
{
    [Serializable]
    public class Human : IntelligentBeing
    {
        [NonSerialized]
        public string Gender = null!;
        
        public Human(string name, DateTime age, string gender) : base(name, age)
        {
            Gender = gender;
        }

        public Human(string name, DateTime age) : base(name, age)
        {
        }

        public Human(): base("undefined", DateTime.Now)
        {
            Gender = "undefined";
        }

        public override string ToString()
        {
            return $"name:{Name}\t age:{Age}\t gender:{Gender}";
        }
    }
}
