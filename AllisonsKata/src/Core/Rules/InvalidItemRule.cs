using Core.Interfaces;

namespace Core.Rules
{
    public class InvalidItemRule : IRule
    {
        private readonly IProduct _product;
        public InvalidItemRule(IProduct product)
        {
            _product = product;
        }
        
        public void Process()
        {
            _product.UpdateProductName(Constants.InvalidItemProductName);
        }
    }
}