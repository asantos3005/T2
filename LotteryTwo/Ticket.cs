namespace LotteryTwo;

public class Ticket
{
    public List<int> MainNumbers { get; set; }


    public Ticket(List<int> initMainNumbers)
    {
        if (initMainNumbers.Count != 6)
        {
            throw new ArgumentException(
                "Lottery draw must have 6 main numbers"
                );
        }

        MainNumbers = initMainNumbers;

    }
}
