namespace laba04
{
    internal interface ITransport
    {
        void Launch();
        void Shutdown();
        bool ReadinessСheck();
        void Drive();

        void SpeedControl();
    }
}
