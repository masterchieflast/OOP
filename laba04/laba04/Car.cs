namespace laba04
{
    public class Car : CarManagement, ITransport
    {
        public void Launch()
        {
            Engine.Status = true;
        }

        public void Shutdown()
        {
            Engine.Status = false;
        }

        public bool ReadinessСheck()
        {
            return Engine.Status && Fuel > 0;
        }

        public void Drive()
        {
            if (ReadinessСheck())
            {
                Fuel -= FuelСonsumption / 100;
                Mileage++;
            }
        }

        public Car(int countPassengers, string? model, Engine engine, double weight, double fuel) : base(countPassengers, model, engine, weight, fuel)
        {
        }
    }
}
