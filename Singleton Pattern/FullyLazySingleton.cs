namespace DesignPatterns.Singleton_Pattern

{
    /// <summary>
    /// Fullylazy Singleton loading 
    /// </summary>
    public sealed class FullyLazySingleton
    {
        public string Name = "Fully Lazy Singleton";

        public FullyLazySingleton()
        {
        }

        public static FullyLazySingleton Instance { get {return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {
            }
            internal static readonly FullyLazySingleton instance = new FullyLazySingleton();
        }
    }
}
