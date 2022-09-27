namespace laba04
{
    public abstract class CarManagement : TransportVehicle
    {
        public string? Model;
        public Engine? Engine;
        public int Weight;
        public double FuelСonsumption => Engine.Power * 10 / Weight;
        public int Transmission
        {
            get => Transmission;
            set
            {
                if (value is < 1 or > 6)
                {
                    Console.WriteLine("you car no support {0} transmission", value);
                }

                Transmission = value;
            }
        }
        public int Mileage;
        private double fuel;
        public double Fuel
        {
            get => fuel;
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("age can't negative");
                }

                fuel = value;
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
    }
}