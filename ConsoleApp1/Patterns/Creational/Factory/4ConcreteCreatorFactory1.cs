using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Patterns.Factory
{
    public class _4ConcreteCreatorFactory : _3CreatorFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public _4ConcreteCreatorFactory(int creditLimit, int annualCharge)
        {
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }

        public override _1ProductAbstractclass GetProduct()
        {
            return new _2ConcreteProduct1(_creditLimit, _annualCharge);
        }
    }
}
