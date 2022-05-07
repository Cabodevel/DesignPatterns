using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
/// Factory Method lets a class defer instantiation to subclasses.
/// </summary>
namespace NetCoreDesignPatterns.Patterns.Factory
{
    public abstract class _1ProductAbstractclass
    {
        public abstract string CardType { get; }
        public abstract int CreditLimit { get; set; }
        public abstract int AnnualCharge { get; set; }


    }
}
