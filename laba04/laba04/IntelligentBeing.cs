namespace laba04
{
    public abstract class IntelligentBeing : object
    {
        public string Name;
        private int _age;

        protected IntelligentBeing(string name, int age)
        {
            Name = name;
            _age = age;
        }
        

        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("age can't be negative");
                }

                _age = value;
            }
        }

        public void Birthday()
        {
            Age++;
        }

        public override string ToString()
        {
            return $"this creature:{Name}\t live:{Age} year";
        }
    }
}
