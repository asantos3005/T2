using System;

namespace LotteryTwo;

public static class LotteryGenerator
{

    public static List<int> GenerateUniqueRandomNumbers(int count, int minValue, int maxValue)
    {
        var random = new Random();
        var numbers = new HashSet<int>();

        while (numbers.Count < count)
        {
            numbers.Add(random.Next(minValue, maxValue + 1));
        }

        return numbers.ToList();
    }
}
