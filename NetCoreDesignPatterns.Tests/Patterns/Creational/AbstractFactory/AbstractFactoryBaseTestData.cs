using NetCoreDesignPatterns.Patterns.Creational.Abstract_factory;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace NetCoreDesignPatterns.Tests.Patterns.Creational.AbstractFactory
{
    public abstract class AbstractFactoryBaseTestData : IEnumerable<object[]>
    {
        private readonly TheoryData<ImobilePhone, Type> _data = new TheoryData<ImobilePhone, Type>();
        protected void AddTestData<TConcreteFactory, TExpectedVehicle>()
            where TConcreteFactory : ImobilePhone, new()
        {
            _data.Add(new TConcreteFactory(), typeof(TExpectedVehicle));
        }
        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
