﻿namespace lab13
{
    public abstract class IntelligentBeing
    {
        public string Name;

        protected IntelligentBeing(string name, DateTime birthday)
        {
            Name = name;
            _birthday = birthday;
        }
        
        private readonly DateTime _birthday;
        public TimeSpan Age => DateTime.Now.Subtract(_birthday) / 365;


        public override string ToString()
        {
            return $"this creature:{Name}\t live:{Age} year";
        }
    }
}
