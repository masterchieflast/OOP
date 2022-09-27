namespace laba04
{
    public sealed class Transformer : IntelligentBeing, ITransport
    {
        public Engine Heart { get; }
        private double _energy;
        private bool _transformationStatus;
        private const double EnergyСonsumption = 5.5;

        public double Energy
        {
            get => _energy;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("energy can't be negative");
                }

                _energy = value;
            }

        }

        public Transformer(Engine engine, string name, int age, double energy) : base(name, age)
        {
            Heart = engine;
            Energy = energy;
            _transformationStatus = false;
        }

        public void Transformation()
        {
            _transformationStatus = !_transformationStatus;
        }

        public void Launch()
        {
            Heart.Status = true;
        }

        public void Shutdown()
        {
            Heart.Status = false;
        }

        public bool ReadinessСheck()
        {
            return Heart.Status && Energy > 0;
        }

        public void Drive()
        {
            if (ReadinessСheck())
            {
                Energy -= EnergyСonsumption / 100;
            }
        }

        public void SpeedControl()
        {
            if (_transformationStatus)
            {
                Console.WriteLine(Heart.Power * 24);
            }
            else
            {
                Console.WriteLine("Parking");
            }
        }

        public override string ToString()
        {
            return $"transformer {Name} was created {Age} years ago";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Transformer transformer)
            {
                if (transformer.Name == Name && transformer.Age == Age && Math.Abs(transformer.Energy - Energy) < 0.001
                    && transformer.Heart == Heart && transformer._transformationStatus == _transformationStatus)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Age.GetHashCode();
        }
    }
}
