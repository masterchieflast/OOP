namespace laba04
{
    internal class IntelligentBeing
    {
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("age can't negative");
                }

                age = value;
            }
        }
    }
}
