Console.WriteLine("Шаг 1");
Console.WriteLine("Шаг 2");
Console.WriteLine("Шаг 3");
// Выполняется строго сверху вниз
{
    int x = 5;
    int y = 10;
    int sum = x + y;
    Console.WriteLine($"Сумма: {sum}");
}
// После выполнения блока переменные x, y, sum недоступны