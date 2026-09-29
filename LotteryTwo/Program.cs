using LotteryTwo;

LotteryDraw myDraw = new LotteryDraw(LotteryGenerator.GenerateUniqueRandomNumbers(6, 1, 49), LotteryGenerator.GenerateUniqueRandomNumbers(2, 1, 10));
LotteryDraw officalDraw = new LotteryDraw(LotteryGenerator.GenerateUniqueRandomNumbers(6, 1, 49), LotteryGenerator.GenerateUniqueRandomNumbers(2, 1, 10));