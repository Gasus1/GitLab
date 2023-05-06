List<int> numbers = new List<int>();
Console.WriteLine("Введіть тип заповнення списку автоматично/вручну: auto/hand");
string choice = Console.ReadLine();
switch (choice)
{
    case "auto":
        AutoType(numbers, numsQuantity("Введіть кількість чисел у списку:"));
        break;
    case "hand":
        UserType(numbers, numsQuantity("Введіть кількість чисел у списку:"));
        break;
    default:
        Console.WriteLine("Такого варіанту немає");
        break;
}
for (int i = 0; i < numbers.Count; i++)
{
    Console.Write(numbers[i] + "\t");
}
Console.WriteLine();
for (int i = 0; i < numbers.Count; i++)
{
    numbers[i] = -numbers[i];
}
numbers.Sort();
for (int i = 0; i < numbers.Count; i++)
{
    numbers[i] = -numbers[i];
}
for (int i = 0; i < numbers.Count; i++)
{
    Console.Write(numbers[i] + "\t");
}
static int NumsQuantity(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        try
        {
            int ListQuantity = int.Parse(Console.ReadLine());
            return ListQuantity;
        }
        catch
        {
            Console.WriteLine("Символ у неправильному форматі, спробуйте ще раз!");
        }
    }
}
static void UserType(List<int> numbers, int numsQuantity)
{
    while (true)
    {
        try
        {
            for (int i = 0; i < numsQuantity; i++)
            {
                Console.Write("Введіть число:\t");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            break;
        }
        catch
        {
            Console.WriteLine("Ви ввели символ у неправильному форматі, спробуйте ще раз!");
        }
    }
}
static void AutoType(List<int> numbers, int numsQuantity)
{
    Random random = new Random();
    for (int i = 0; i < numsQuantity; i++)
    {
        numbers.Add(random.Next(-10, 10));
    }
}
