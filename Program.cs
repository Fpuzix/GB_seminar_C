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

