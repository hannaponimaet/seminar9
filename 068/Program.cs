/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

    Console.WriteLine();
    Console.Write("Введите первое число: ");
    int firstNumber = int.Parse(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int secondNumber = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (firstNumber < 0 || secondNumber < 0)
    {
        Console.WriteLine("Пожалуйста, введите положительные числа.");
        return;
    }
    int result = AckermannFunction(firstNumber, secondNumber);
    Console.WriteLine("Полученный ответ по формуле Аккермана: " + result);

    int AckermannFunction(int firstNumber, int secondNumber)
    {
        if (firstNumber == 0)
        {
            return secondNumber + 1;
        }
        else if (firstNumber > 0 && secondNumber == 0)
        {
            return AckermannFunction(firstNumber - 1, 1);
        }
        else if (firstNumber > 0 && secondNumber > 0)
        {
            return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
        }
        return AckermannFunction(firstNumber, secondNumber);
    }