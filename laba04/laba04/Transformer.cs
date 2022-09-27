namespace laba04
{
    public sealed class Transformer : IntelligentBeing, ITransport
    {
        public Engine Heart { get; }

        public Transformer(Engine engine, string name, int age) : base(name, age)
        {
            Heart = engine;
        }

        public void Launch()
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }

        public bool ReadinessСheck()
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            return $"The transformer was created {Age} years ago";
        }

        public override bool Equals(object? obj)
        {
            if (obj is IntelligentBeing creature)
            {
                if (creature.Name == Name && creature.Age == Age)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return _age.GetHashCode();
        }
    }
}
