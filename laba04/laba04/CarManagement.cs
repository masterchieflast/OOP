namespace laba04
{
    public abstract class CarManagement : TransportVehicle
    {
        public string? Model;
        public Engine? Engine;
        public double Weight;
        public double FuelСonsumption => Engine.Power * 10 / Weight;
        public int Transmission
        {
            get => Transmission;
            set
            {
                Transmission = value;

                if (value is < 1 or > 6)
                {
                    Console.WriteLine("you car no support {0} transmission", value);
                    Transmission = 0;
                }
            }
        }
        public int Mileage;
        private double _fuel;
        public double Fuel
        {
            get => _fuel;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("fuel can't be negative");
                }

                _fuel = value;
            }

        }

        public void SpeedControl()
        {
            if (Transmission == 0)
            {
                Console.WriteLine("Parking");
            }
            else
            {
                Console.WriteLine(Engine.Power * Transmission * 13.5);
            }
        }

        protected CarManagement(int countPassengers, string? model, Engine engine, double weight,
            double fuel) : base(countPassengers)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            _fuel = fuel;
            Transmission = 0;
        }
    }
}