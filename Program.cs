// Напишите программу, которая на вход принимает
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

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num==1)
// {
//     Console.WriteLine("Monday");
// }
// else if (num==2)
// {
//     Console.WriteLine("Tuesday");
// }
// else if (num==3)
// {
//     Console.WriteLine("Wednesday");
// }
// else if (num==4)
// {
//     Console.WriteLine("Thursday");
// }
// else if (num==5)
// {
//     Console.WriteLine("Frieday");
// }

// else if (num==6)
// {
//     Console.WriteLine("Saturday");
// }
// else if (num==7)
// {
//     Console.WriteLine("Sunday");
// }
// else 
// {
//     Console.WriteLine("Error");
// }
//___________________Задание 4________________________

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int negNum = -1*num;

// while (negNum <= num)
// {
//     Console.WriteLine(negNum);
//     negNum = negNum + 1;
// }


// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//________________Домашнее задание____________________
//___________________ЗАДАНИЕ 1________________________

// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите число");

// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");

// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num > num2)
// {

//     Console.Write("Число ");
//     Console.Write(num);
//     Console.Write(" больше, чем ");
//     Console.Write(num2);

// }

// else 
// {

//     Console.Write("Число ");
//     Console.Write(num2);
//     Console.Write(" больше, чем ");
//     Console.Write(num);

// }


//_______________ЗАДАНИЕ 2________________
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите три числа");

// int num = Convert.ToInt32(Console.ReadLine());


// int num2 = Convert.ToInt32(Console.ReadLine());


// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if (num > num2)
// {

//     max=num;

// }

// else 
// {

//     max=num2;

// }

// if (max>num3)
// {
//     Console.Write("Число ");
//     Console.Write(max);
//     Console.Write(" больше.");
// }

// else
// {
//     max=num3;
//     Console.Write("Число ");
//     Console.Write(max);
//     Console.Write(" больше.");
// }

//___________________ЗАДАНИЕ 3______________________
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");

// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 ==0)
// {
// Console.Write("Число ");
// Console.Write(num);
// Console.Write(" четное.");
// }

// else
// {
//     Console.Write("Число ");
// Console.Write(num);
// Console.Write(" не четное.");
// }
//__________________ЗАДАНИЕ 4________________

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int num1=1;

Console.WriteLine("Четные числа");
while (num1 <= num)
{
    if (num1 % 2 == 0)
    {
        
    }
}