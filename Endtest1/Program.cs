const int A = 3;
Console.WriteLine("Программа сортирует массив строк и выделяет элементы массива, ");
Console.WriteLine($"длина которых меньше {A} символов в отдельный массив.");
Console.WriteLine("Генерируем массив для сортировки:");
Console.WriteLine("Определим длину этого массива.");

NumberFromString(out double number);

void NumberFromString(out double number)
{
    string? text;   
    
    while (true)
    {
        Console.WriteLine("Введите целое положительное число, больше 0:");
        text = Console.ReadLine();
        if (double.TryParse(text, out number))
        {
            if ((number > 0) & (number == Convert.ToInt32(number)))
            {
                break;
            }
            else
            {
                Console.WriteLine("Это число не является подходящим.");
            }
        }
        else
        {
            Console.WriteLine("Не удалось распознать число.");
        }

    }
      
}

