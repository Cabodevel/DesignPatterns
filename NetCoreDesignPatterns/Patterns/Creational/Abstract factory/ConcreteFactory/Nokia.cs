using NetCoreDesignPatterns.Patterns.Creational.Abstract_factory.Product;

namespace NetCoreDesignPatterns.Patterns.Creational.Abstract_factory
{
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary>  
    public class Nokia : ImobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new NokiaPixel();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Nokia1600();
        }
    }
}
