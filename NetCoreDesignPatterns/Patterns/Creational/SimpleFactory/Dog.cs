﻿namespace NetCoreDessignPatterns.Patterns.Creational.SimpleFactory
{
    class Dog : IAnimal
    {
        public string Action()
        {
            return "Dog barks";
        }

        public string Speak()
        {
            return "WOW WOW!!!";
        }
    }
}
