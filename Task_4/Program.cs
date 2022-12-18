/* Задача 4:
Напишите программу, которая принимает на вход три числа и выдаёт максимальное
из этих чисел.
*/

/* Алгоритм решения:
1. Выведение в консоль команды: "Введите три числа!";
2. Создание трех переменных под эти числа с вводом их из консоли;
3. Создание переменной max, вкоторой будет храниться ин-ция о максимальном значении переменной;
4. Выполнить операции сравнения с данными числами;
5. Вывести в консоль значение максимальной переменной.
*/

Console.WriteLine("Введите три числа!");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
else if (numberB == numberA)
{
    Console.WriteLine("numberA = numberB");
}
if (numberC > max) max = numberC;
else if (numberC == numberB)
{
    Console.WriteLine("numberB = numberC");
}
else if (numberA == numberC)
{
    Console.WriteLine("numberA = numberC");
}
Console.WriteLine("Максимальное значение   " + max);