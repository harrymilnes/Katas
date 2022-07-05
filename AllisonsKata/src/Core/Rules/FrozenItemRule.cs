using Core.Helpers;
using Core.Interfaces;

namespace Core.Rules
{
    public class FrozenItemRule : IRule
    {
        private readonly IProduct _product;
        public FrozenItemRule(IProduct product)
        {
            _product = product;
        }
        
        public void Process()
        {
            _product.UpdateSellIn(_product.SellIn - 1);
            _product.UpdateQuality(_product.Quality - DeteriorationRateHelper.GetSellInRelatedDeteriorationRate(_product.SellIn, Constants.FrozenItemDeteriorationRate));
        }
    }
}