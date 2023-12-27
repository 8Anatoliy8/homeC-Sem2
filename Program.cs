// // Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 27 == 0)
// {
//     Console.WriteLine($"Число {number} кратно 7 и 27");
// }
// else
// {
//     Console.WriteLine($"Число {number} некратно 7 и 27");
// }

// // Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// // и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


// Console.Write("Введите число X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// if (X>0 && Y>0)
// {
//     Console.WriteLine($"Точка находится в I координатной четверти");
// }
// if (X<0 && Y>0)
// {
//     Console.WriteLine($"Точка находится во II координатной четверти");
// }
// if (X<0 && Y<0)
// {
//     Console.WriteLine($"Точка находится в III координатной четверти");
// }
// if (X>0 && Y<0)
// {
//     Console.WriteLine($"Точка находится в IV координатной четверти");
// }

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int secondNumber = number / 10;
    int thirdNumber = number % 10;
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine($"Наибольшее цифра числа {number} является {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Наибольшее цифра числа {number} является {thirdNumber}");
    }
}
else
{
    Console.WriteLine("Число не двухзначное или отрицательное");
}