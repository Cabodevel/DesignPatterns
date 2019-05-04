using ConsoleApp1.Patterns.Creational.Builder;
using ConsoleApp1.Patterns.Creational.Prototype;
using ConsoleApp1.Patterns.Structural.Composite;
using ConsoleApp1.Patterns.Structural.Decorator;
using ConsoleApp1.Threading.Volatile;
using DesignPattern.Patterns;
using DesignPattern.Patterns.Behavioral.Iterator;
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
            #region -Patterns methods calls
            //GetSingletonPattern();
            //GetFactoryPattern();
            //GetAbstractFactoryPattern();
            //GetFacadePattern();
            //GetFacadePattern2();
            //GetAdapterPattern();
            //GetIteratorPattern();
            //GetDecoratorPattern();
            //GetCompositePattern();
            GetBuilderPattern(); 
            //GetPrototypePattern();
            #endregion

            #region -Threading Methods calls
            //BackgroundTaskDemo.MainThread();
            #endregion
            Console.ReadKey();
        }


        #region -Creational patterns

        private static void GetPrototypePattern()
        {
            Console.WriteLine("***Prototype Pattern***\n");
            //Base or Original Copy
            BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
            BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };
            BasicCar bc1;
            //Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",bc1.ModelName,bc1.Price);
            //Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}",
            bc1.ModelName, bc1.Price);
            Console.ReadLine();
        }

        private static void GetBuilderPattern()
        {
            // Create director and builders
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadKey();
        }

        private static void GetSingletonPattern()
        {
            SingletonClass s = SingletonClass.Instance;
            SingletonClass s2 = SingletonClass.Instance;

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

        private static void GetDecoratorPattern()
        {
            VehiculoBase v = new VehiculoBase();

            Console.WriteLine(v.GetDatosVehiculos());
            Camion cm = new Camion(v);
            Console.WriteLine(cm.GetDatosVehiculos());

            CamionConRemolque c = new CamionConRemolque(cm);
            c.Peso = 10000;
            Console.WriteLine(c.GetDatosVehiculos());
            CamionConRemolqueFrio cF = new CamionConRemolqueFrio(c);
            cF.Temperatura = 10;
            Console.WriteLine(cF.GetDatosVehiculos());
            Console.WriteLine(((CamionConRemolque)cF.VehiculoPadre).Peso);

            Console.WriteLine(cF.Temperatura);

        }

        private static void GetCompositePattern()
        {
            VehiculoBaseComposite v = new VehiculoBaseComposite();

            Console.WriteLine(v.GetChilds());
            CamionComposite cm = new CamionComposite(v);
            Console.WriteLine(cm.GetChilds());
            CamionConRemolqueComposite c = new CamionConRemolqueComposite(cm);
            c.Peso = 10000;
            Console.WriteLine(c.GetChilds());
            CamionConRemolqueFrioComposite cF = new CamionConRemolqueFrioComposite(cm);
            cF.Temperatura = 10;
            Console.WriteLine(cF.GetChilds());
            cF.Remove(cm);
            cF.Remove(c);
            Console.WriteLine(cF.Temperatura);
            Console.WriteLine(cF.GetChilds());
        }

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
        private static void GetIteratorPattern()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }
        #endregion
    }



}
