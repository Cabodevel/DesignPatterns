using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDessignPatterns.Patterns.Creational
{
    /// <summary>
    /// Director class. Sets the parts of IBuilder
    /// </summary>
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    #region Concrete builders
    /// <summary>
    /// Implements IBuilder and can be build by Director class
    /// </summary>
    class ConcreteBuilder1 : IBuilder

    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add(new ComplexObject("o1", true));
        }

        public void BuildPartB()
        {
            _product.Add(new ComplexObject("o2", false));
        }

        public Product GetResult()
        {
            return _product;
        }
    }

    class ConcreteBuilder2 : IBuilder

    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add(new ComplexObject("o3", true));
        }

        public void BuildPartB()
        {
            _product.Add(new ComplexObject("o4", false));
        }

        public Product GetResult()
        {
            return _product;
        }
    } 
    #endregion

    /// <summary>
    /// Is the class that needs to add complex objects
    /// </summary>
    class Product
    {
        private List<ComplexObject> _parts = new List<ComplexObject>();

        public void Add(ComplexObject part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (var part in _parts)
            {
                Console.WriteLine(part.Name);
                Console.WriteLine(part.IsValid);

            }
        }
    }

    /// <summary>
    /// An object to test
    /// </summary>
    public class ComplexObject
    {
        public string Name { get; set; }
        public bool IsValid { get; set; }
        public ComplexObject(string name, bool isvalid)
        {
            Name = name;
            IsValid = isvalid;
        }
    }
}
