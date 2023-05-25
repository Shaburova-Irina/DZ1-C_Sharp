
// ЗАДАЧА №1
// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// Console.Write("Веевдите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Веевдите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//   Console.Write(num1);
//   Console.Write(" больше ");
//   Console.WriteLine(num2);
// }

// else if (num2 > num1)
// {
//   Console.Write(num2);
//   Console.Write(" больше ");
//   Console.Write(num1);
// }
// else
// {
//   Console.WriteLine("Числа равны");
// }
// ======================================================================================================

//   Задача №2
//   Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Веевдите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Веевдите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Веевдите третье число:");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if (num1 > num2)
// {
//   max = num1;
// }
// else
// {
//   max = num2;
// }
  
// if (num3 > max)
// {
//   max = num3;
// }

// Console.Write("Максимальное число = ");
// Console.WriteLine(max);

//===================================================================================================================

// ЗАДАЧА №3
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2 == 0)
// {
//   Console.WriteLine("Число четное");
// }
// else
// {
//   Console.WriteLine("Число не четное");
// }

//============================================================================================================================

// ЗАДАЧА №4

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num2= 1;

while (num2 <= number)
{
  if (num2%2 == 0)
  {
    Console.WriteLine(num2);
    num2++;
  }
  else
  {
    num2++;
  }
}
