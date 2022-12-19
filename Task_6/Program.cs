﻿/* Задача №6:
Напишите программу, которая на вход принимает число и выдаёт, является ли число
чётным (делится ли оно на два без остатка).
*/

/* Алгоритм решения:
1. Вывод в консоль команды: "Введите число!";
2. Создание переменной для данного числа;
3. Проверка переменной на четность;
4. Если число чётное - выводим в консоль: "Да, число чётное!"
5. Если чисне нечетное - выводим в консоль: "Нет, число нечетное!"
*/

Console.WriteLine("Введите число для проверки!");

int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.Write("Да, число " + numberA + " четное!");
}
else
{
    Console.Write("Нет, число " + numberA + " нечетное!");
}