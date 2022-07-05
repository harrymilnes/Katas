using Core.Interfaces;
using Core.Rules;

namespace Core.Models
{
    public class Product : IProduct
    {
        public string Name { get; private set; }
        public int SellIn { get; private set; }
        public int Quality { get; private set; }
        public IRule Rule => RuleFactory.GetProductRule(this);

        public static Product Create(
            string name,
            int sellIn, 
            int quality)
        {
            return new Product
            {
                Name = name,
                SellIn = sellIn,
                Quality = quality
            };
        }

        public string Output()
        {
            if (Name == Constants.InvalidItemProductName)
                return $"{Name}";
            
            var displayQuality = GetDisplayQuality();
            return $"{Name} {SellIn} {displayQuality}";
        }

        private int GetDisplayQuality()
        {
            if (Quality >= Constants.MaximumItemQuality) return Constants.MaximumItemQuality;
            if (Quality <= Constants.MinimumItemQuality) return Constants.MinimumItemQuality;
            
            return Quality;
        }

        public void UpdateSellIn(int sellIn)
        {
            SellIn = sellIn;
        }
        
        public void UpdateQuality(int quality)
        {
            Quality = quality;
        }

        public void UpdateProductName(string name)
        {
            Name = name;
        }
    }
}