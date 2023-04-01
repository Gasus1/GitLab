List<int> list = new List<int> {14, 28, 76, 54 };
var result = list.Select(x => x % 10).Aggregate(1, (a, b) => a * b);
Console.WriteLine(result);         


