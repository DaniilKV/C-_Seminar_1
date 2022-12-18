/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число
большее, а какое меньшее.
a = 5; b = 7 -> max = 7
*/

/* Алгоритм решения:
- Вывод в консоль команды на ввод двух чисел;
- Задание переменных для данных чисел и ввод их в консоли;
- Создание условия для сравнения данных чисел (число А > числа Б, число Б > числа А,
 числа равны);
- Вывод в консоль какое из чисел меньшее, какое большее.
*/

Console.WriteLine("Введите два числа");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Число " + numberA + " > " + "числа " + numberB);
}
else if (numberA < numberB)
{
    Console.Write("Число " + numberA + " < " + "числа " + numberB);
}
else if (numberA == numberB)
{
    Console.Write("Число " + numberA + " = " + "числу " + numberB);
}