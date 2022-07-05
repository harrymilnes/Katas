using Core.Interfaces;

namespace Core.Rules
{
    public static class RuleFactory
    {
        public static IRule GetProductRule(IProduct product)
        {
            switch(product.Name)
            {
                case Constants.AgedBrieProductName:
                    return new AgedBrieRule(product);
                case Constants.ChristmasCrackersProductName:
                    return new ChristmasCrackerRule(product);
                case Constants.SoapProductName:
                    return new SoapRule();
                case Constants.FrozenItemProductName:
                    return new FrozenItemRule(product);
                case Constants.FreshItemProductName:
                    return new FreshItemRule(product);
            }
            
            return new InvalidItemRule(product);
        }
    }
}