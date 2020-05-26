namespace DesignPatterns.Singleton_Pattern

{
    /// <summary>
    /// Double Null Check Thread Safe double Null Check using Property.
    /// </summary>
    public sealed class ThreadSafeDoubleCheckSingleton
    {
        public string Name { get; set; }
        private static ThreadSafeDoubleCheckSingleton instance = null;

        private static readonly object padLock = new object();

        public static ThreadSafeDoubleCheckSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padLock)
                    {
                        if (instance == null)
                        {
                            instance = new ThreadSafeDoubleCheckSingleton();
                            instance.Name = "Thread Safe Double Check Singleton";
                        }
                    }
                }
                return instance;
            }
        }
    }
}
