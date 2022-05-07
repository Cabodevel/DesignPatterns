namespace NetCoreDessignPatterns.Patterns.Creational.SimpleFactory
{
    class SimpleFactory : ISimpleFactory
    {
        public IAnimal CreateAnimal(int input)
        {
            switch (input)
            {
                case 0:
                    return new Dog();
                case 1:
                    return new Tiger();
                default:
                    return null;
            }
        }
    }
}
