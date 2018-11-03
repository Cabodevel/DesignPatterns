using DesignPattern.Patterns;
using DesignPattern.Patterns.Creational.Abstract_factory;
using DesignPattern.Patterns.Creational.Abstract_factory.Client;
using DesignPattern.Patterns.Factory;
using DesignPattern.Patterns.Structural.Adapter;
using DesignPattern.Patterns.Structural.Facade;
using DesignPattern.Patterns.Structural.Facade.Ejemplo2;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetSingletonPattern();
            //GetFactoryPattern();
            //GetAbstractFactoryPattern();
            //GetFacadePattern();
            //GetFacadePattern2();
            GetAdapterPattern();
            Console.ReadKey();
        }

        #region -Creational patterns

        private static void GetSingletonPattern()
        {
            SingletonClass s = SingletonClass.Instance();
            SingletonClass s2 = SingletonClass.Instance();

            if (s == s2)
                Console.WriteLine("s and s2 are equals");
            else
                Console.WriteLine("s and s2 are NOT equals");
        }

        private static void GetFactoryPattern()
        {
            int value = -1;
            do
            {
                _3CreatorFactory creatorFactory = null;
                Console.Write("Elija producto");
                value = int.Parse(Console.ReadLine());
                if (value > 0 & value < 3)
                {
                    switch (value)
                    {
                        case 1:
                            creatorFactory = new _4ConcreteCreatorFactory(5000, 500000);
                            break;
                        case 2:
                            creatorFactory = new _4ConcreteCreatorFactory2(1000, 10000);
                            break;
                        default:
                            break;
                    }

                    _1ProductAbstractclass productoFinal = creatorFactory.GetProduct();
                    Console.WriteLine($"Tipo de tarjeta: {productoFinal.CardType}{Environment.NewLine} " +
                        $"Limite de crédito: {productoFinal.CreditLimit}{Environment.NewLine}" +
                        $"Carga anual: {productoFinal.AnnualCharge}");
                    Console.ReadKey();
                }
            } while (value != 0);


        }

        private static void GetAbstractFactoryPattern()
        {
            ImobilePhone nokiaMobilePhone = new Nokia();
            MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            Console.WriteLine("********* NOKIA **********");
            Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            ImobilePhone samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Console.WriteLine("******* SAMSUNG **********");
            Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

            Console.ReadKey();
        } 

        #endregion

        #region -StructuralPatterns
        private static void GetAdapterPattern()
        {
            ValidAdapterClass validAdapter = new ValidAdapterClass();
            validAdapter.CurrentSpeedInKilometersPerHour = 4;
            validAdapter.Jump(5);
            Console.ReadKey();
        }

        private static void GetFacadePattern()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user

            Console.ReadKey();
        }

        private static void GetFacadePattern2()
        {
            Centralita c = new Centralita(new Embrague1(), new Acelerador1(), new PalancaCambios1());
            c.AumentarMarcha();
            c.ReducirMarcha();
        }

        #endregion

        #region -Behavioral Patterns
            
        #endregion
    }



}
