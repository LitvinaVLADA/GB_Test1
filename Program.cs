// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] FilterArray(string[] inputArray, int leng) //метод для фильтра значений массива по длине строки
    {
        int count = 0;

        // Подсчет количества строк, длина которых меньше или равна заданного количества символов
        foreach (string str in inputArray)
        {
            if (str.Length <= leng)
                count++;
        }

        // Создание результирующего массива
        string[] resultArray = new string[count];
        int index = 0;

        // Заполнение результирующего массива
        foreach (string str in inputArray)
        {
            if (str.Length <= leng)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }

string[] ConvertStringToArray(string start_mes) //метод для генерации массива из строки
    {
        Console.WriteLine(start_mes);
        string input = Console.ReadLine();
        
        string[] array = input.Split(' ');
        Console.Write("Заданный массив чисел:"); 
        PrintArray (array); //вывод массива в терминал
        return array;
    }
    

void PrintArray(string[] arr) //метод для печати массива в терминал
{
    Console.Write("(");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + ")");
}

string[] Integers = ConvertStringToArray("Введите числа через пробел:"); //выводим строку и создаём массив из введёных пользователем чисел
string[] FilterIntegers =  FilterArray (Integers, 3); //фильтруем массив по заданному параметру длины
Console.Write ("Числа содержащие 3 или меньше цифр: ");
PrintArray (FilterIntegers); //печатаем отфильтрованный массив


