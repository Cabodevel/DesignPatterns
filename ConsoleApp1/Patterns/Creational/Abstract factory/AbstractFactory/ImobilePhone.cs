namespace ConsoleApp1.Patterns.Creational.Abstract_factory
{
    //1 Abstract factory
    public interface ImobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
