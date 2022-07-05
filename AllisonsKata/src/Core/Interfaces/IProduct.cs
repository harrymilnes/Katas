namespace Core.Interfaces
{
    public interface IProduct
    {
        public string Name { get; }
        public int SellIn { get; }
        public int Quality { get; }
        public string Output();
        void UpdateSellIn(int sellIn);
        void UpdateQuality(int quality);
        void UpdateProductName(string name);
    }
}