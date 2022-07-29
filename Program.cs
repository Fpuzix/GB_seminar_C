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


// Console.Write("input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num%2!=0) {
//     Console.WriteLine( num + " is odd");
// }

// else {
//     Console.WriteLine( num + " is even");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

// Console.Write("input number N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum;
// sum=0;

// while (sum < num) {
//     sum=sum+2;
//     Console.Write(sum + " ");
// }

// Seminar 2

// Задача: Напишите программу которая выводит случайное число из атрезка [10, 99] и показывает нибольшую цифру числа.

// void ShowNumber(){
//     int num = new Random().Next(10, 100);
//     int firstNum = num / 10;
//     int secondNum = num % 10;
//     Console.Write(num + "->");
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine(secondNum);
//     }
// }

// ShowNumber();

// Задача № 11. Напишите программу, которая выводит случаное трехзначное число и удаляет вторую цифру этого числа.

// void ShowNumber(){
//     int num = new Random().Next(100, 1000);
//     int firstNum = num / 100;
//     int secondNum = firstNum * 10;
//     int thirdNum = num % 10;
//     int sum = secondNum + thirdNum;
//     Console.Write(num + "->" + sum);
// }
// ShowNumber();

// Задача № 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// void multiNum(int a, int b){
//     if(b%a == 0){
// Console.WriteLine (b + " кратно " + a);
//     }
//     else{
//         Console.WriteLine(b + " некратно " + a + ", остаток " + b%a);
//     }
// }
// Console.Write("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// multiNum(num1, num2);

// Задача № 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// void multiNum(int a){
//     if(a%7 == 0 && a%23 ==0){
// Console.WriteLine (a + " кратно 7 и 23 ");
//     }
//     else{
//         Console.WriteLine(a + " некратно 7 и 23 ");
//     }
// }
// Console.Write("Enter first number: ");

// int num1 = Convert.ToInt32(Console.ReadLine());

// multiNum(num1);

// Задача № 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void multiNum(int a , int b){
//     if(a == b * b || b == a * a){
// Console.WriteLine (" yeees!!! ");
//     }
//     else{
//         Console.WriteLine(" nooou(( ");
//     }

// }

// Console.Write("input first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// multiNum(num1, num2);

// Задача № 10: Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.

// void ShowNumber(int num){
//     int firstNum = num / 100;
//     int secondNum = num / 10;
//     int sum = secondNum - firstNum * 10;

//     if (sum==0){
//     Console.Write("nema second cifra");
//     }
//     else{
//         Console.WriteLine(sum);
//     }
// }

// Console.Write("input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1>99 && num1<1000){
//     ShowNumber(num1);
// }
// else{
//     Console.WriteLine ("need number between 99 and 1000");
// }


// Задача № 13: Напишите программу, которая выводит третью цифры заданного числа или сообщает, что третьей цифры нет.

void ShowNumber(int num){
    while (num>999){
        num=num/10;
    }
    if (num<100){
        Console.WriteLine ("third cifra is out");
    }
    else {
        int sum = num%10;
        Console.WriteLine (sum);
    }
}

Console.Write("input number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

ShowNumber(num1);
