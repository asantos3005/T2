namespace LotteryTwo;

public static class LotteryComparer
{
    public static int CompareNumbers(OfficialDraw draw1, Ticket draw2)
    {
        int matchingMainNumbers = draw1.MainNumbers.Intersect(draw2.MainNumbers).Count();
        int matchingBonusNumbers = draw1.BonusNumbers.Intersect(draw2.MainNumbers).Count();

        return matchingMainNumbers + matchingBonusNumbers;
    }
}