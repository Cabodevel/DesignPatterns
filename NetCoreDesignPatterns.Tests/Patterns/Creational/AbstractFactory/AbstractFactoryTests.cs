using NetCoreDesignPatterns.Patterns.Creational.Abstract_factory;
using NetCoreDesignPatterns.Patterns.Creational.Abstract_factory.Product;
using System;
using Xunit;

namespace NetCoreDesignPatterns.Tests.Patterns.Creational.AbstractFactory
{
    public class AbstractFactoryTestsNokia : AbstractFactoryBaseTestData
    {
        public AbstractFactoryTestsNokia()
        {
            AddTestData<Nokia, NokiaPixel>();
            //AddTestData<Nokia, INormalPhone>();
        }
    }
    public class AbstractFactoryTestSamsung : AbstractFactoryBaseTestData
    {
        public AbstractFactoryTestSamsung()
        {
            AddTestData<Samsung, SamsungGalaxy>();
            //AddTestData<Samsung, INormalPhone>();
        }
    }

    public class Tests
    {
        [Theory]
        [ClassData(typeof(AbstractFactoryTestsNokia))]
        public void Should_create_a_Car_of_the_specified_type(ImobilePhone mobileFactory, Type expectedMobileType)
        {
            // Act
            var result = mobileFactory.GetSmartPhone();
            // Assert
            Assert.IsType(expectedMobileType, result);
        }
        [Theory]
        [ClassData(typeof(AbstractFactoryTestSamsung))]
        public void Should_create_a_Bike_of_the_specified_type(ImobilePhone mobileFactory, Type expectedMobileType)
        {
            // Act
            var result = mobileFactory.GetSmartPhone();
            // Assert
            Assert.IsType(expectedMobileType, result);
        }
    }
}
