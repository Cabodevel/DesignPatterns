
namespace ConsoleApp1.Patterns.Factory
{
    public class _4ConcreteCreatorFactory2 : _3CreatorFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public _4ConcreteCreatorFactory2(int CreditLimit, int AnnualCharge)
        {
            _creditLimit = CreditLimit;
            _annualCharge = AnnualCharge;
        }

        public override _1ProductAbstractclass GetProduct()
        {
            return new _2ConcreteProduct2(_creditLimit, _annualCharge);
        }
    }
}
