namespace LotteryTwo;

public class LotteryDraw
{
    public List<int> MainNumbers { get; set; }
    public List<int> BonusNumbers { get; set; }



    public LotteryDraw(List<int> initMainNumbers, List<int> initBonusNumbers)
    {
        if (initMainNumbers.Count != 6)
        {
            throw new ArgumentException(
                "Lottery draw must have 6 main numbers"
                );
        }

        if (initBonusNumbers.Count != 2)
        {
            throw new ArgumentException(
                "Lottery draw must have 2 bonus numbers"
                );
        }
        MainNumbers = initMainNumbers;
        BonusNumbers = initBonusNumbers;
    }
}
