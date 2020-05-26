namespace DesignPatterns.Singleton_Pattern

{
    /// <summary>
    /// Lazy Load method to create a singleton threadsafe 
    /// </summary>
    public sealed class LazyLoadSingleton
    {
        public string Name = "Lazy Load Singleton";
        static LazyLoadSingleton() {}

        private LazyLoadSingleton(){}

        public static LazyLoadSingleton Instance { get ;  } = new LazyLoadSingleton();
    }
}
