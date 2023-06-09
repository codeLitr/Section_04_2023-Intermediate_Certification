﻿// Задача 64:
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintInterval(int N)
{
    if (N <= 0) //Проверка введенного числа (натуральное или нет).
    {
        System.Console.Write("Ошибка ввода - ненатуральное число.\""); // (\") - добавлен вывод кавычек в начале по аналогии с примером в условиях задач.
    }
    else
    {
        if (N <= 1)
        {
            System.Console.Write($"{N}\""); // (\") - добавлен вывод кавычек в конце по аналогии с примером в условиях задач.
            return;
        }
        System.Console.Write(N + ", ");
        PrintInterval(N - 1);
    }
}

int N = 100;
System.Console.Write($"N = {N} -> \""); // (\") - добавлен вывод кавычек в начале по аналогии с примером в условиях задач.
PrintInterval(N);
