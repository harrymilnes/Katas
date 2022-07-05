namespace Core
{
    public static class Constants
    {
        public const string AgedBrieProductName = "Aged Brie";
        public const string ChristmasCrackersProductName = "Christmas Crackers";
        public const string SoapProductName = "Soap";
        public const string FrozenItemProductName = "Frozen Item";
        public const string FreshItemProductName = "Fresh Item";
        public const string InvalidItemProductName = "NO SUCH ITEM";

        public const int FrozenItemDeteriorationRate = 1;
        public const int FreshItemDeteriorationRate = FrozenItemDeteriorationRate * 2;

        public const int MaximumItemQuality = 50;
        public const int MinimumItemQuality = 0;

        public const int NormalChristmasCrackersMatureRate = 1;
        public const int ChristmasCrackersEarlyMatureSellIn = 10;
        public const int ChristmasCrackersEarlyMatureRate = 2;
        public const int ChristmasCrackersLateMatureSellIn = 5;
        public const int ChristmasCrackersLateMatureRate = 3;
    }
}