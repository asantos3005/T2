using LotteryTwo;

OfficialDraw myDraw = new OfficialDraw(LotteryGenerator.GenerateUniqueRandomNumbers(6, 1, 49), LotteryGenerator.GenerateUniqueRandomNumbers(2, 1, 10));
Ticket officialDraw = new Ticket(LotteryGenerator.GenerateUniqueRandomNumbers(6, 1, 49));

int matchingNumbers = LotteryComparer.CompareNumbers(myDraw, officialDraw);

Console.WriteLine($"Matching numbers: {matchingNumbers}");