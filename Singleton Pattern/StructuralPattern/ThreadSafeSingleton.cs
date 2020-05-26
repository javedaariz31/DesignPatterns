namespace DesignPatterns.Singleton_Pattern

{
    /// <summary>
    /// Thread safe Singleton class object
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
        public string Name { get; set; }

        private static ThreadSafeSingleton instance = null;

        private static readonly object padLock = new object();

        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                        instance.Name = "Thread Safe Singleton";
                    }
                    return instance;
                }
            }
        }
    }
}
