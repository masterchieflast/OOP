namespace laba04
{
    public interface ITransport
    {
        
        void Launch();
        void Shutdown();
        bool ReadinessСheck();
        void Drive();

        void SpeedControl();
    }
}
