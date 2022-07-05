namespace Core.Helpers
{
    public static class DeteriorationRateHelper
    {
        public static int GetSellInRelatedDeteriorationRate(int sellIn, int deteriorationRate)
        {
            if (sellIn > 0) return deteriorationRate;
            return deteriorationRate * 2;
        }
    }
}