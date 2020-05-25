using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton_Pattern
{
    /// <summary>
    /// Calling different versions of the Singleton classes. 
    /// </summary>
    public class SingletonPattern
    {
        public SingletonPattern()
        {
            Console.WriteLine($"Single instance using a Property : {PropertySingleton.Instance}");
            Console.WriteLine($"Singleton Thread Safe Property : {ThreadSafeSingleton.Instance}");
            Console.WriteLine($"Singleton Thread Safe Double Null Check Property : {ThreadSafeDoubleCheckSingleton.Instance}");
            Console.WriteLine($"Singleton Thread without Check : {LazyLoadSingleton.Instance}");
            Console.WriteLine($"Singleton Nested Check : {FullyLazySingleton.Instance}");
            Console.WriteLine($"Singleton Nested Check : {GenericSingleton.Instance}");

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Non Thread-Safe Version 
    /// </summary>
    public sealed class PropertySingleton
    {
        private static PropertySingleton instance = null;
        public static PropertySingleton Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new PropertySingleton();
                }
                return instance;
            }
        }
    }

    /// <summary>
    /// Thread safe Singleton class object
    /// </summary>
    public sealed class ThreadSafeSingleton
    {
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
                    }
                    return instance;
                }
            }
        }
    }

    /// <summary>
    /// Double Null Check Thread Safe double Null Check using Property.
    /// </summary>
    public sealed class ThreadSafeDoubleCheckSingleton
    {
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
                        }
                    }
                }
                return instance;
            }
        }
    }

    /// <summary>
    /// Lazy Load method to create a singleton threadsafe 
    /// </summary>
    public sealed class LazyLoadSingleton
    {
        static LazyLoadSingleton() {}

        private LazyLoadSingleton(){}

        public static LazyLoadSingleton Instance { get; } = new LazyLoadSingleton();
    }

    /// <summary>
    /// Fullylazy Singleton loading 
    /// </summary>
    public sealed class FullyLazySingleton
    {
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

    /// <summary>
    /// using .NET 4's Lazy<T> type
    /// </summary>
    public sealed class GenericSingleton
    {
        private static readonly Lazy<GenericSingleton> lazy = new Lazy<GenericSingleton>(() => new GenericSingleton());
        
        public static GenericSingleton Instance { get { return lazy.Value; } }

        private GenericSingleton() { }
    }

}
