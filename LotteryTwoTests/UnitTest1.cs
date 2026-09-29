namespace LotteryTwoTests;

using LotteryTwo;

public class UnitTest1
{
    [Fact]
    public void generates_unique_random_numbers()
    {
        // Arrange
        int count = 6;
        int minValue = 1;
        int maxValue = 49;

        // Act
        List<int> randomNumbers = LotteryGenerator.GenerateUniqueRandomNumbers(count, minValue, maxValue);

        // Assert
        Assert.Equal(count, randomNumbers.Count);
        Assert.Equal(count, randomNumbers.Distinct().Count());
        Assert.All(randomNumbers, number => Assert.InRange(number, minValue, maxValue));

    }
}
