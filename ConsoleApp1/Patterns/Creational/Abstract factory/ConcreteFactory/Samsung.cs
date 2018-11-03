using DesignPattern.Patterns.Creational.Abstract_factory.Product;

namespace DesignPattern.Patterns.Creational.Abstract_factory
{
    /// <summary>  
    /// The 'ConcreteFactory2' class.  
    /// </summary>  
    public class Samsung : ImobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new SamsungGuru();
        }
    }
}
