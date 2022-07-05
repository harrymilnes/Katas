using Core.Interfaces;

namespace Core.Rules
{
    public class AgedBrieRule : IRule
    {
        private readonly IProduct _product;
        public AgedBrieRule(IProduct product)
        {
            _product = product;
        }
        
        public void Process()
        {
            _product.UpdateSellIn(_product.SellIn - 1);
            _product.UpdateQuality(_product.Quality + 1);
        }
    }
}