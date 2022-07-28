// /* 1. Напишите программу, которая на входе принимает число и выдает его квадрат (число умножается на себя).
// Console.WriteLine("input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is " + result);


// 2. Напишите программу, которая на входе принимает два числа и проверяет, является ли первое число к...

// Console.Write("first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 ==square){
// Console.WriteLine("first number is a square of second number ");
// }
// else {
//    Console.WriteLine("first number is not a square of second number ");
// }
// // 3. Напишите программу, которая будет выдавать названия дня недели по заданному номеру.

// Console.Write("first number a day: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1|| day >7) {
//     Console.WriteLine("incorrect day");
// }
// else{
//     if (day == 1){
//     Console.WriteLine ("Monday");
//     }
//      if (day == 2){
//     Console.WriteLine ("Thuesday");
//     }
// }

// 4. Напишите программу, которая на входе принимает одно число N а выходе показывает все целые числа олт -N до +N.

// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current;
// if (num < 0) {
//     current = num;
//     num=num* (-1);
// }
// else{
//     current= -1 * num;
// }

// while(current < num-1){
//     current++;
//     Console.Write(current + "");
// }

// 5. Напишите программу, которая принимает на вход трехзначное число и на выходе выводит последние число.

// Console.Write("input N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num % 10);

// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое больше, а капкое меньше.

// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2) {
//     Console.WriteLine("It's a joke? they a equal!");
//   }

// if (num1>num2) {
// Console.WriteLine(num1 + " bigger!");
// Console.WriteLine(num2 + " smaller!");
// }
// if (num2>num1) {
// Console.WriteLine(num2 + " bigger!");
// Console.WriteLine(num1 + " smaller!");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int maximum;
// maximum = num1;

// if (num1==num2||num2==num3||num1==num3){
//     Console.WriteLine("Need different numbers!");
// }
// else {
// if (num2 > maximum){
//     maximum = num2;
// }

// if (num3 > maximum){
//     maximum = num3;
// }

// Console.WriteLine( maximum + " bigger than others");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).


Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2!=0) {
    Console.WriteLine( num + " is odd");
}

else {
    Console.WriteLine( num + " is even");
}


