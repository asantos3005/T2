
public class LotteryDraw
{
    private readonly List<int> _numbers;

    public IReadOnlyList<int> Numbers => _numbers;

    public LotteryDraw(List<int> initNumbers)
    {

        if (initNumbers.Count != 6)
        {
            throw new ArgumentException(
                "Lottery draw must have 6 numbers"
                );
        }

        if (initNumbers.Count != 6)
        {
            throw new ArgumentException(
                "Lottery draw must have 6 numbers"
                );
        }
        _numbers = initNumbers;
    }


}