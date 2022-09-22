/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите первое число: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    int sumNumber = 0;
    Console.Write($"Все натуральные от числа {firstNumber} до {secondNumber}: ");
    while (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        sumNumber = sumNumber + firstNumber;
        firstNumber = firstNumber + 1;
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма натуральных чисел {sumNumber}");
