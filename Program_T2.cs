using Newtonsoft.Json;

Dictionary<int, int> dict = new Dictionary<int, int>();
Random random = new Random();
int sum = 0;
for (int i = 0; i < 10; i++)
{
    dict.Add(i, random.Next(-10, 10));
    Console.Write(dict[i] + "\t");
    sum += dict[i];
}
//int sum = dict.Aggregate((a, b) => a + b);
var t = dict.Values.Sum();
foreach (int i in dict.Keys)
{
    dict[i] = sum;
}
Console.WriteLine();
foreach (var i in dict)
{
    Console.WriteLine(i.Key + " " + i.Value);
}
string json = JsonConvert.SerializeObject(dict);
Console.WriteLine(json);

