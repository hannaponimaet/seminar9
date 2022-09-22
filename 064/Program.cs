/* Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

    int firstNumber = new Random().Next(1, 5);
    Console.WriteLine("Полученное рандомно первое число: " + firstNumber);
    int secondNumber = new Random().Next(5, 9);
    Console.WriteLine("Полученное рандомно второе число: " + secondNumber);
    Console.Write($"Все натуральные от числа {firstNumber} до {secondNumber}: ");
    while (firstNumber <= secondNumber)
    {
        Console.Write($"{firstNumber} ");
        firstNumber = firstNumber + 1;
    }

