// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.WriteLine("вводим число 1");
int num1 = int.Parse (Console.ReadLine()!);
Console.WriteLine("введи число 2");
int num2 = int.Parse (Console.ReadLine()!);
if(num1 > num2){
Console.WriteLine ($"{num1} является больше {num2}");
}
else
{Console.WriteLine ($"{num2} является больше {num1}");
}*/




// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
/*Console.WriteLine("вводим число 1");
int num3 = int.Parse(Console.ReadLine()!);
Console.WriteLine("вводим число 2");
int num4 = int.Parse(Console.ReadLine()!);
Console.WriteLine("вводим число 3");
int num5 = int.Parse(Console.ReadLine()!);
if (num3>num4 && num3>num5){
    Console.WriteLine ($"наибольшее {num3}");
}
else if (num4>num5){
    Console.WriteLine ($"{num4} является больше {num5}");
}
else {
Console.WriteLine ($"{num5} является больше ");
}*/




// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
/*Console.WriteLine("вводим число ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0){
    Console.WriteLine ($"{number} является четным");
}
else {
Console.WriteLine ($"{number} является не четным");
}*/

// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("вводим число ");
int a = int.Parse(Console.ReadLine()!);
int m1 = 1;

while(m1 <= a){
    Console.Write($"{m1} ");
    m1++;
}


