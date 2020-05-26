namespace DesignPatterns.Singleton_Pattern
{
    /// <summary>
    /// using .NET 4's Lazy<T> type
    /// </summary>
    public sealed class GenericSingleton
    {
        public string Name = "Generic Singleton";

        private static readonly System.Lazy<GenericSingleton> lazy = new System.Lazy<GenericSingleton>(() => new GenericSingleton());
        public static GenericSingleton Instance { get { return lazy.Value; } }

        private GenericSingleton() { }
    }
}
