using System;
using System.Collections.Generic;
using System.IO;
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
            //C: \Users\Mohammed Javed\source\repos\DesignPatterns\Singleton Pattern\StructuralPattern\PropertySingleton.cs
            Console.WriteLine($"***** Creational Pattern *****");
            Console.WriteLine($"{PropertySingleton.Instance.Name}");
            string PropertySingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "PropertySingleton.cs"));
            Console.WriteLine($"Full Code --- {Environment.NewLine}  {PropertySingletonCode} ");

            Console.WriteLine($"{ThreadSafeSingleton.Instance.Name}");
            string ThreadSafeSingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "ThreadSafeSingleton.cs"));
            Console.WriteLine($"Full Code --- {Environment.NewLine}  {ThreadSafeSingletonCode} ");

            Console.WriteLine($"{ThreadSafeDoubleCheckSingleton.Instance.Name}");
            string ThreadSafeDoubleCheckSingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "ThreadSafeDoubleCheckSingleton.cs"));
            Console.WriteLine($"Full Code ---{Environment.NewLine}  {ThreadSafeDoubleCheckSingletonCode} ");

            Console.WriteLine($"{LazyLoadSingleton.Instance.Name}");
            string LazyLoadSingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "LazyLoadSingleton.cs"));
            Console.WriteLine($"Full Code --- {Environment.NewLine} {LazyLoadSingletonCode} ");

            Console.WriteLine($"{FullyLazySingleton.Instance.Name}");
            string FullyLazySingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "FullyLazySingleton.cs"));
            Console.WriteLine($"Full Code --- {Environment.NewLine}  {FullyLazySingletonCode} ");

            Console.WriteLine($"{GenericSingleton.Instance.Name}");
            string GenericSingletonCode = File.ReadAllText(Path.Combine("..\\..\\Singleton Pattern\\StructuralPattern", "GenericSingleton.cs"));
            Console.WriteLine($"Full Code --- {Environment.NewLine}  {GenericSingletonCode} ");

            Console.WriteLine($"**** **** **** ****");

            Console.ReadKey();
        }
    }

}
