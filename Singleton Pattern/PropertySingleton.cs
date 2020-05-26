namespace DesignPatterns.Singleton_Pattern

{
    /// <summary>
    /// Non Thread-Safe Version 
    /// </summary>
    public sealed class PropertySingleton
    {
        public string Name { get; set; }
       
        private static PropertySingleton instance = null;
        public static PropertySingleton Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new PropertySingleton();
                    instance.Name = "Property Initialized Singleton Class";
                }
                return instance;
            }
        }
    }
}
