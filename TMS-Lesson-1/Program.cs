// 1) Считать число из консоли и вывести на консоль число противоположного знака.
ReverseNumberSign();
// 2) Считать из консоли два числа и вывести все числа между ними на консоль 
LogNumbersBetween();
// 3) Возле дороги стоят столбы. Расстояние между столбами одинаковое и ширина столбов одинаковая. 
// Программа считывает из консоли 3 числа: количество столбов, расстояние между столбами(в метрах),
// ширину столба(в сантиметрах). Рассчитайте расстояние между первым и последним столбом
// в сантиметрах (без ширины первого и последнего столба).
CountPillarsDistance();

static void CountPillarsDistance()
{
    Console.WriteLine("Задание #3");
    Console.WriteLine("Количество столбов");
    int numberOfPillars = ReadIntFromConsole();
    Console.WriteLine("Расстояние между столбами(в метрах)");
    int pillarsDistanceInterval = ReadIntFromConsole();
    Console.WriteLine("Ширина столба(в сантиметрах)");
    int pillarWidth = ReadIntFromConsole();

    int result = ((numberOfPillars - 2) * pillarWidth) + ((numberOfPillars -1) * pillarsDistanceInterval * 100);

    Console.WriteLine("Расстояние между столбами: {0}", result);
}
static void LogNumbersBetween()
{
    Console.WriteLine("Задание #2");
    int firstNumber = ReadIntFromConsole();
    int secondNumber = ReadIntFromConsole();
    string result = String.Empty;
    int beginningRangeNumber = firstNumber < secondNumber ? firstNumber : secondNumber; 
    int endingRangeNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
  
    for (int i = beginningRangeNumber +1; i < endingRangeNumber; i++)
    {
        result += $"{i}, ";


    }

    Console.WriteLine("Числа между {0} и {1} => {2}", firstNumber, secondNumber, result);
    Console.WriteLine();
}
static void ReverseNumberSign()
{
    Console.WriteLine("Задание #1"); int inputNumber = ReadIntFromConsole();
    Console.WriteLine("Введенное число: {0}", inputNumber);
    Console.WriteLine("Число противоположного знака: {0}", inputNumber * -1);
    Console.WriteLine();
}
static int ReadIntFromConsole ()
{
    Console.WriteLine("Введите число: ");
    string ? input = Console.ReadLine();
    bool isNumberValid = int.TryParse(input, out int number);

    if (!isNumberValid)
    {
        throw new Exception("Invalid Number Entered!");
    }

    return number;
}