﻿// Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на само себя).

//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49

// Console.WriteLine("Введите число");

// int num = Convert.ToInt32(Console.ReadLine());

// int num2 = num*num;

// Console.WriteLine(num2);
//________________Задание 2___________________

// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num==num2*num2)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// _____________Задание 3__________________

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num==1)
{
    Console.WriteLine("Monday");
}
else if (num==2)
{
    Console.WriteLine("Tuesday");
}
else if (num==3)
{
    Console.WriteLine("Wednesday");
}
else if (num==4)
{
    Console.WriteLine("Thursday");
}
else if (num==5)
{
    Console.WriteLine("Frieday");
}

else if (num==6)
{
    Console.WriteLine("Saturday");
}
else if (num==7)
{
    Console.WriteLine("Sunday");
}
else 
{
    Console.WriteLine("Error");
}