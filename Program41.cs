﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 5
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//вариация задачи 41 - пользователь не задает сколько чисел он введет (то есть число M), 
//а подсчет количества чисел производится после того, как пользователь не ввел информацию и нажал Enter.

Console.WriteLine("Введите M чисел через  пробел  и запятую:  ");
 int [] numbers = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
 int count = 0;
 for (int i=0; i<numbers.Length; i++)
{
    if (numbers[i] >0)  count++;  
}
Console.WriteLine(count);