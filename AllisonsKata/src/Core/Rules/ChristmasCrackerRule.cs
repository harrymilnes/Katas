using Core.Interfaces;

namespace Core.Rules
{
    public class ChristmasCrackerRule : IRule
    {
        private readonly IProduct _product;
        public ChristmasCrackerRule(IProduct product)
        {
            _product = product;
        }
        
        public void Process()
        {
            _product.UpdateSellIn(_product.SellIn - 1);

            if (_product.SellIn <= 0)
            {
                _product.UpdateQuality(0);
            } 
            else if (_product.SellIn > Constants.ChristmasCrackersEarlyMatureSellIn)
            {
                _product.UpdateQuality(_product.Quality + Constants.NormalChristmasCrackersMatureRate);
            }
            else if (_product.SellIn <= Constants.ChristmasCrackersEarlyMatureSellIn && _product.SellIn > Constants.ChristmasCrackersLateMatureSellIn)
            {
                _product.UpdateQuality(_product.Quality + Constants.ChristmasCrackersEarlyMatureRate);
            }
            else
            {
                _product.UpdateQuality(_product.Quality + Constants.ChristmasCrackersLateMatureRate);
            }
        }
    }
}