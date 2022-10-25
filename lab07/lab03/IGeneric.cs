namespace lab07
{
    interface IGeneric<T> where T : class
    {
        void Add(T dt);
        void Delete(T dt);
        void Show();
    }
}
