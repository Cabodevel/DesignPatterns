﻿namespace NetCoreDessignPatterns.Patterns.Creational.SimpleFactory
{
    class Tiger : IAnimal
    {
        public string Action()
        {
            return "Tiger is hunting";
        }

        public string Speak()
        {
            return "GROAR!!!";
        }
    }
}
