# Итоговое задание
**Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.**

# Решение:
**const int A** - задает количество символов в элементе, меньше количества которых, программа будет создавать отсортированный массив. По условиям задачи равна 3.

*Строки 2-5:*
Блок взаимодействия с пользователем: ознакомление с условиями задачи; ввод с клавиатуры размера массива для сортировки.

*Строка: 7-8:*

* Запуск функции **NumberFromString**  - позволяет опознать число **number**. Формат числа **double**. В данной задаче число будет целым, положительным, больше 0 (можно было приводить сразу к int, но это всу равно произойдет в следующей строке, а формат double позволяет скорректировать ввод чисел пользователем с клавиатуры). 

* Присвоение длине сортируемого массива **LengthRandomArray**  целочисленного значения (задано пользователем).

*Строка:10:*

Запуск функции **GenerationRandomStringArray** - создает **string RandomStringArray** массив случайно сгенерированных строк для последующей сортировки. На вход принимает длину массива **LengthRandomArray**.

*Строка: 12-22:*

Сортировка массива **RandomStringArray**;

Создание и заполнение отсортированного массива **string SortedStringArray**, состоящего из элементов, количество символов в которых удовлетворяет условиям задачи **(меньше или равно 3).**

**string[ ] SortedStringArray** - отсортированный массив, состоящий из элементов, количество символов в которых удовлетворяет условиям задачи **(меньше или равно 3)** Изначальная длина массива - 0, тк возможен случай, когда в сортируемом массиве не окажется элементов, удовлетворяющих условиям задачи.

**int i** - индекс элемента массива **RandomStringArray;**

**int j** = 0 - индекс элементов массива **SortedStringArray;**

**Цикл** - обход элементов массива **RandomStringArray**

**Внутри цикла** - сортировка элементов массива **RandomStringArray**:

* Если длина элемента **RandomStringArray[ i ].Length <= A (3):** 
    Длина массива **SortedStringArray** увеличивается на 1 (метод **Array.Resize**) и элемент записывается в этот массив. 
* **Иначе:** переход к следующему элементу массива **RandomStringArray.**

*Строки 24-37:*

Вывод результатов работы программы пользователю:

*Строки 24-29:* Если нет элементов, удовлетворяющих условиям задачи.

*Строки 30-37:* Если есть элементы, удовлетворяющие условиям задачи. Вывод в консоль отсортированного массива **SortedStringArray**.

## Описание использованных функций:

 ### **1. NumberFromString:**

Функция **void NumberFromString(out double number)** - позволяет опознать число, вводимое пользователем с клавиатуры, и удовлетворяющее определенным условиям. Выводит число для дальнейшего использования.

*В данной задаче:* символы должны быть быть целым, положительным числом, больше 0.

**string text** - символы, вводимые пользователем с клавиатуры

**double number** - число, из **string text.**
Для преобразования символов в число использован метод **double.TryParse**

### **2.GenerationRandomStringArray**

Функция **void GenerationRandomStringArray (int LengthRandomArray, out string[ ] RandomStringArray)** - на вход принимает заданную ранее пользователем длину массива, выводит string массив, состоящий из случайно сгенерированных элементов.

**string[] SimbolsArray** - массив исходных символов для генерации элементов массива **RandomStringArray**.

**const int MaxLengthElement = 5** - константа, определяющая максимальное количество символов в элементе массива;

**string ElementArray = string.Empty** - элемент массива, изначально имеет длину 0 символов;

**int LengthElementArray** - количество символов в элементе массива **ElementArray**, определяется случайным образом, с помощью переменной **rand,** класса Random, в диапазоне до MaxLengthElement.

**Цикл внешний** - заполнение массива **RandomStringArray** сгенерированными элементами, где
**index** - индексы этого массива;

**Цикл внутренний** - создание отдельного элемента **ElementArray** массива из  исходных символов (массив **SimbolsArray**), где
**index1** - индекс символа внутри **ElementArray.**