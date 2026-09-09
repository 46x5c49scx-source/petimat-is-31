internal class NewBaseType
{
    private static void Main(string[] args)
    {
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
        // Следование: ввод данных, вычисление, вывод результата
        Console.Write("Введите ширину: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Введите высоту: ");
        double height = double.Parse(Console.ReadLine());

        double area = width * height;          // Вычисление
        double perimeter = 2 * (width + height); // Вычисление

        Console.WriteLine($"Площадь: {area}");
        Console.WriteLine($"Периметр: {perimeter}");

    }
    
}