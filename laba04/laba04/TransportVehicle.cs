namespace laba04
{
    public abstract class TransportVehicle
    {
        public int CountPassengers;

        protected TransportVehicle(int countPassengers)
        {
            CountPassengers = countPassengers;
        }
    }
}
