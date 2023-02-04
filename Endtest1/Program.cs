const int A = 3;
Console.WriteLine("Программа сортирует массив строк и выделяет элементы массива, ");
Console.WriteLine($"длина которых меньше {A} символов в отдельный массив.");
Console.WriteLine("Генерируем массив для сортировки:");
Console.WriteLine("Определим длину этого массива.");

NumberFromString(out double number);
int LengthRandomArray = Convert.ToInt32(number);

GenerationRandomStringArray(LengthRandomArray, out string[] RandomStringArray);

string[] SortedStringArray = new string[0];
int j = 0;
for (int i = 0; i < LengthRandomArray; i++)
{
    if (RandomStringArray[i].Length <= A)
    {
        Array.Resize(ref SortedStringArray, SortedStringArray.Length + 1);
        SortedStringArray[j] = RandomStringArray[i];
        j++;
    }
}

if (SortedStringArray.Length == 0)
{
    Console.WriteLine($"Создан массив из {LengthRandomArray} элементов:");
    Console.WriteLine($"{String.Join("  ", RandomStringArray)}");
    Console.WriteLine($"Сгенерированный массив не содержит элементов, длина которых меньше или равна {A}");
}
else
{
    Console.WriteLine($"Создан массив из {LengthRandomArray} элементов:");
    Console.WriteLine($"{String.Join("  ", RandomStringArray)}");
    Console.WriteLine($"Массив содержит {SortedStringArray.Length} элементов, длина которых меньше или равна {A}");
    Console.WriteLine("Это элементы:");
    Console.WriteLine(String.Join("  ", SortedStringArray));
}

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

void GenerationRandomStringArray(int LengthRandomArray, out string[] RandomStringArray)
{
    string[] SimbolsArray ={"1","2","3","4","5","6","7","8","9","0","-","=","!","@","#","$","%","^","&","*","(",
")","_","+","`","~","q","w","e","r","t","y","u","i","o","p","[","]","a","s","d","f","g","h","j","k","l","z","x",
"x","c","v","b","n","m","/","Q","W","E","R","T","Y","U","I","O","P","{","}","|","A","S","D","F","G","H","J","K",
"L",":","Z","X","C","V","B","N","M","<",">","?"};
    RandomStringArray = new string[LengthRandomArray];
    const int MaxLengthElement = 5;
    string ElementArray = string.Empty;
    int LengthElementArray;
    Random rand = new Random();

    for (int index = 0; index < LengthRandomArray; index++)
    {
        LengthElementArray = rand.Next(MaxLengthElement);
        for (int index1 = 0; index1 <= LengthElementArray; index1++)
        {
            ElementArray = ElementArray + SimbolsArray[rand.Next(0, SimbolsArray.Length - 1)];
        }
        RandomStringArray[index] = ElementArray;
        ElementArray = string.Empty;
    }
}

