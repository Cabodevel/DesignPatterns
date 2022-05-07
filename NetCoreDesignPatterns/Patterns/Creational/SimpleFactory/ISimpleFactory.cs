namespace NetCoreDessignPatterns.Patterns.Creational.SimpleFactory
{
    interface ISimpleFactory
    {
        IAnimal CreateAnimal(int input);
    }
}
