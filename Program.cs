﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] FilterArray(string[] inputArray) //метод для фильтра значений массива по длине строки
    {
        int count = 0;

        // Подсчет количества строк, длина которых меньше или равна 3 символам
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
                count++;
        }

        // Создание результирующего массива
        string[] resultArray = new string[count];
        int index = 0;

        // Заполнение результирующего массива
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }

        return resultArray;
    }
    
string[] CreateStringArray(string start) //метод для заполнения массива именами
{
    Console.WriteLine(start);
    string input = Console.ReadLine();

    // Разделение строки на отдельные слова
    string[] words = input.Split(' ');

    return words;
}

string[] Names = CreateStringArray("Введите имена через пробел:");



