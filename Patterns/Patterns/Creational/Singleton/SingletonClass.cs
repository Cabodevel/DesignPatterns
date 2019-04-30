namespace DesignPattern.Patterns
{
    public sealed class SingletonClass
    {
        private static volatile SingletonClass _singleton = new SingletonClass();
        private static int _instances = 0;
        private static readonly object _collisionLock = new object();

        private SingletonClass()
        {
            _instances++;
        }

        public static SingletonClass Instance
        {
            get { lock (_collisionLock) { return _singleton; } }
        }

    }
}
