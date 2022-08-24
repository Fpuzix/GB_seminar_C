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

// void ShowNumber(int num){
//     while (num>999){
//         num=num/10;
//     }
//     if (num<100){
//         Console.WriteLine ("third cifra is out");
//     }
//     else {
//         int sum = num%10;
//         Console.WriteLine (sum);
//     }
// }

// Console.Write("input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// ShowNumber(num1);

// Задача № 15: Напишите программу, которая принимает на вход цифру обозначающую день недели, и проверяет, является ли этот день выходной.

// void ShowNumber(int num){

//     if (num>7 || num<1){
//         Console.WriteLine ("Wrong day! Try again!");
//     }
//     if (num < 6 && num > 0){
//         Console.WriteLine ("working day");
//     }
//     if (num < 8 && num > 5){
//         Console.WriteLine ("it's a weekend!!!");
//     }
// }

// Console.Write("input number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// ShowNumber(num1);


// Seminar 3


// Задача № 17: Напишите программу, которая принимает на вход координаты точки (х и у), причем Х не равно 0 и У не равно 0 выдеет номер четверти плоскости в которой находиться эта точка.

// void getDot (int x, int y){
//     if (x == 0 || y == 0) {
//     Console.WriteLine ("Нет возможности определить четветь");
//     }
//     else{
//         if (x > 0 && y >0){
//             Console.WriteLine ("1 четверть");
//         }
//         if (x > 0 && y < 0){
//         Console.WriteLine ("4 четверть");
//         }
//         if (x < 0 && y > 0){
//             Console.WriteLine ("2 четверть");
//         }
//         if (x < 0 && y < 0){
//         Console.WriteLine ("3 четверть");
//         }
//     }
// }
//     Console.WriteLine ("Введите две точки");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     int y1 = Convert.ToInt32(Console.ReadLine());

//     getDot(x1, y1);


// Задача № 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (Х и У).

// void getDot (int x){
//     if (x == 1){
//         Console.WriteLine ("x > 0 and y >0");
//     }
//     else if (x == 4){
//         Console.WriteLine ("x > 0 and y < 0");
//     }
//     else if (x == 2){
//         Console.WriteLine ("x < 0 and y > 0");
//     }
//     else if (x == 3){
//         Console.WriteLine ("x < 0 and y < 0");
//     }
//     else {Console.WriteLine ("Введено некорректное число!");
//     }
//     }

// Console.WriteLine ("Введите номер четверти");
// int x = Convert.ToInt32(Console.ReadLine());

// getDot(x);

// Задача № 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Console.Clear();

// double distAB(int x1, int x2, int y1, int y2)
// {
//     return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2));
// }

// Console.WriteLine("Введите координату x1: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату a2: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату b2: ");
// int b = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distAB(x, y, a, b), 2);

// Console.WriteLine("Длина отрезка: " + res);

// && для инморта: import lib;


// Задача № 22: Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N.

// Console.Clear();

// void listSqrt(int n)
// {
//     int count = 1;
//     Console.Write(n + "-->");
//     if (n > 0)
//     {
//         while (count <= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count++;
//         }
//     }
//     else
//     {
//         count = -1;
//         while (count >= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count--;
//         }
//     }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);


// Задача № 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом.

// Console.Clear();

// void polindrom(int n)
// {
//     int first = n / 10000;
//     int second = n / 1000 - first*10;
//     int fifth = n % 10;
//     int forth = (n % 100 - fifth)/10;

//     if (first == fifth && second == forth)
//     {
//         Console.WriteLine(n + "--> полиндром");
//     }
//     else
//     {
//         Console.WriteLine(n + "--> не полиндром!");
//     };
// }

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// polindrom(num);


// Задача № 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();

// double distABC(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow(Math.Abs((x2 - x1)), 2) + Math.Pow(Math.Abs((y2 - y1)), 2) + Math.Pow(Math.Abs((z2 - z1)), 2));
// }

// Console.WriteLine("Введите координату x1: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y1: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z1: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату x2: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату z2: ");
// int c = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(distABC(x, y, z, a, b, c), 2);

// Console.WriteLine("Длина отрезка: " + res);



// Задача № 23: Напишите программу, которая принимает на вход число N  и выдает таблицу кубов чисел от 1 до N.


// Console.Clear();

// void listSqrt(int n)
// {
//     int count = 1;
//     Console.Write(n + "-->");
//     if (n > 0)
//     {
//         while (count <= n)
//         {
//             Console.Write(Math.Pow(count, 3) + ", ");
//             count++;
//         }
//     }
//     else
//     {
//         count = -1;
//         while (count >= n)
//         {
//             Console.Write(Math.Pow(count, 3) + ", ");
//             count--;
//         }
//     }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);


//  Seminar 4


// Задача № 24: Напишите программу, которая примание на вход число А и выдает сумму чисел от 1 до А.

// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));


// Задача № 26: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// int countNum(int num)

// {
//     int count = 0;
//     while (num>0)

//     {
//      num = num / 10;
//      count++;
//     }
//     return (count);
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ответ " + countNum(number));


// Задача №: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

// int sumToNum(int num)
// {
//     int multiplay = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         multiplay *= i;
//     }
//     return multiplay;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));


// Задача № 30: Напишите программу, которая выводит массив из 8 элементов, заполненый нулями и единицами в случайном порядке.
// создаем массив случайных чисел, где size - количество элементов в массиве, min - это  началоа диапазона случайных чисел, max - до какого генерирует.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// // создаем массив из чисел, которые вводим.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.Write("input " + i + " elemets: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // выводим значения элементов массива в однус троку черех пробел.

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(size: 8, min: -10, max: 10);
// ShowArray(myRandomArray);
// Console.WriteLine();
// int[] myArray = CreateArray(6);
// ShowArray(myArray);


// Задача № 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// Console.Clear();

// void result(int n, int m)
// {
//     Console.Write(Math.Pow(n, m));

// }

// Console.WriteLine("Input first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// result(firstNum, secondNum);

// Задача № 27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

// int countSum(int num)

// {
//     int sum = 0;

//     while (num > 0)

//     {
//         sum = sum + num % 10;
//         num = num / 10;
//     }
//     return (sum);

// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ответ " + countSum(number));


// Задача № 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next();
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }


// int[] myRandomArray = CreateArray(size: 8);
// ShowArray(myRandomArray);
// Console.WriteLine();


// Seminar № 5

// Пример форматирования

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0} Возраст: {1}", name, age)

// int number = 23;
// string result = string.Format("{0:f}", number);
// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f5}", number2);
// Console.WriteLine(result2);

// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name} Возраст: {age}");

// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x+y}";
// Console.WriteLine(result);

// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}") // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}") // пробелы до


// Задача № 31: Задайте массив из 12 элементов, заполненный случайными числами из промежтка -9, 9. Найдите сумму отрицательных и положительных элементов массива.


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos =0;
// int sum_neg =0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i]>0)
//     sum_pos+= myArray[i];
//     else
//     sum_neg+=myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");


// Задача № 32: Напишите программу замена элементов массива: положительный элементы замените на соответствующие отрицательные, и наоборот.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int [] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] *= -1;
// }

// ShowArray(myArray);


// Задача № 33: Задайте массив. Напишите программу, которая определяет, присутсвует ли заданное число в массиве.


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("input integer number: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int ArrayCheck(int[] array, int num)
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         if (myArray[i] == num)
//         {
//             return 1;

//         }
//     }
//     return 0;

// }

// ArrayCheck(myArray, n);

// if (ArrayCheck(myArray, n) == 1)
// {
//     Console.WriteLine($"{n} ЕСТЬ");
// }

// else
// {

//     Console.WriteLine($"{n} НЕТ");
// }


// Задача № 34: Задайте массив заполненный случаными положительными и трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int ArrayCheck(int[] array)
// {

//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }

//     }
//     return count;
// }

// int[] myArray = CreateRandomArray(size: 8, min: 100, max: 999);
// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"--> {ArrayCheck(myArray)}");


// Задача № 36: Задачайте одномерный массив, заполненный случаными числами. найдите сумму элементов, стоящих на нечетных позициях.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int ArraySum (int[] array)
// {

//     int sum = 0;

//     for (int i = 1; i < array.Length; i+=2)
//     {
//         sum+= array[i];
//     }
//     return sum;
// }

// int[] myArray = CreateRandomArray(size: 8, min: 0, max: 100);
// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"--> {ArraySum(myArray)}");


// Задача № 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int Array(int[] array)
// {

//     int max = array[0];
//     int min = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//             if (array[i] < min)
//             {
//                 min = array[i];
//             }
//         }

//     }
//     return max - min;
// }

// int[] myArray = CreateRandomArray(size: 8, min: 0, max: 100);
// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine($"--> {Array(myArray)}");


// // Задача № 35: Задайте одномерный массив из 123 случайных чисел. найдите количество элементов массива, значение которых лежит в отрезке [10, 99].

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// int Array(int[] array)
// {

//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 10 && array[i]<=99)
//         {
//             count++;

//         }

//     }
//     return count;
//     Console.WriteLine();
//     Console.WriteLine(count);
// }

// int[] myArray = CreateRandomArray(size: 123, min: 0, max: 200);
// ShowArray(myArray);
// Console.WriteLine("-->");
// Console.WriteLine(Array(myArray));


// Seminar № 6.


// Задача № Написать программу, которая перевернет одномерный массив.

// int[] CreateRandomArray(int size, int min = 10, int max = 100)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SwapArray(int[] array)
// {
//     int buf = 0;

//     for (int i = 0; i < array.Length/2; i++)
//     {
//         buf = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = buf;
//     }
//     ShowArray(array);
// }

// void SwapArray1(int[] array)
// {
//     int[] arr = new int[array.Length];

//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }

//     ShowArray(arr);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateRandomArray(size);

// ShowArray(arr);
// Console.WriteLine();
// SwapArray(arr);
// Console.WriteLine();
// SwapArray1(arr);


// Задача № __: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугошльника, каждая сторона треугольника меньше суммы двух дроугихз сторон)

// bool NewNum(double a, double b, double c){

// if (a < b + c && b < a + c && c < b + a)
// {
//     return true;
// }
// else
// {
//     return false;
// }
// }
// double num1 = new Random().NextDouble();
// Console.WriteLine("{0:f5}", num1);
// double num2 = new Random().NextDouble();
// Console.WriteLine("{0:f5}",num2);
// double num3 = new Random().NextDouble();
// Console.WriteLine("{0:f5}",num3);

// if (NewNum(num1, num2, num3))
// {
//     Console.WriteLine("существует");
// }
// else
// {
//     Console.WriteLine("неа");
// }


// Задача № 43: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениеями y=k1*x+b1, y=k2*x+b2;
// значения b1, k1, b2 И k2 задаются пользователем.

// Console.Write("first number B1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("second number K1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("first number B2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("second number K2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());

// int x = 0;
// int y =0;

// x=(b2-b1)/(k1-k2);
// y=k1*x+b1;

// Console.WriteLine($"ось х {x} ось y {y}");


// Задача № _**_: перевести 10тичное число в двоичное число.

// int ConvertDecBin(int num){

// int BinNum = 0;
// int count = 0;
// while (num>= 1){

//     if (count == 0) count =1;
//     else count = count*10;
//     BinNum=BinNum + (num%2)*count;
//     num=num/2;
// }
// return BinNum;
// }

// Console.WriteLine ("введите число");
// int DecNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum + "->" + ConvertDecBin(DecNum));

// Пришлось подглядеть(((.


// Seminar № 7.

// Задача № 46: Задайте двумерный массив размером мхн, заполненный случайными целыми числами.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//            array[i,j] = new Random().Next(min, max + 1); 
//         }

//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j] + " ");
//        }
//       Console.WriteLine();        
//     }

// }

// int[,] myArray = CreateRandomArray(3,4,1,10);
// ShowArray(myArray);



// Задача № __: Задачайте двумерный массив размера М на Н, каждый элемент в массиве находится по формуле Аmn = m+n. Выведите полученный массив на экран.

// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = i + j;
//         }

//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] myArray = CreateArray(3, 4);
// ShowArray(myArray);


// Задача № 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//            array[i,j] = new Random().Next(min, max + 1); 
//         }

//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j] + " ");
//        }
//       Console.WriteLine();        
//     }

// }
// void EvenArray(int[,] array)
// {

//     for (int i = 2; i < array.GetLength(0); i++)
//     {
//        for (int j = 2; j < array.GetLength(1); j++)
//        {
//         if (i%2==0 && j%2==0)
//         array[i,j]*=array[i,j];
//        }
//       Console.WriteLine();        
//     }

// }

// int[,] myArray = CreateRandomArray(3,4,1,10);
// ShowArray(myArray);
// EvenArray(myArray);
// ShowArray(myArray);


// Задача № 51: Задачайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }

// }

// int sumNum(int[,] array)
// {

//     int sum = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];

//         };
//         }

//     }
//     return sum;
// }

// int[,] myArray = CreateRandomArray(3, 4, 1, 10);
// ShowArray(myArray);
// Console.WriteLine(sumNum(myArray));


// Задача № 47: Задчайте двумерный массив размером М на Н, заполненный случайными вещественными числами.

// double[,] GetArray(int m, int n, int min, int max)
// {
// double[,] result = new double [m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         result[i,j] = new Random().NextDouble()*(max-min);
//     }
// }
// return result;
// }


// void ShowArray(double[,] inArray)
// {

//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]:f1}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] array = GetArray(m, n, 1, 10);

// ShowArray(array);



// Задача № 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этоо элемента или же указание, что такого элемента нет.


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// bool FindElement(int[,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == el) return true;
//         }
        
//     }
//     return false;
// }


// Console.WriteLine("input rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input colums: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите значение элемента: ");
// int el = int.Parse(Console.ReadLine());

// int[,] array = GetArray(m, n, 1, 10);

// ShowArray(array);

// if (FindElement(array, el))
// {
//     Console.WriteLine("Элемент найден");
// }
// else
// {
//     Console.WriteLine("Элемент не найден!");
// }

// Задача № 52: Зайдайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = GetArray(m,n, 0, 10);

// ShowArray(array);

// double[] averageColumns = GetResultArray(array);
// Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max);
//         }
//     }
//     return result;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }

// double [] GetResultArray(int[,] array)
// {
// double[] result = new double [array.GetLength(1)];
// for (int column = 0; column < array.GetLength(1); column++)
// {
//     double sum = 0;
//     for (int row = 0; row < array.GetLength(0); row++)
//     {
//         sum+= array[row, column];
//     }
//     result[column] = Math.Round(sum/array.GetLength(0),2);
// }
// return result;
// }



// Seminar № 8.


// Задача № 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Console.WriteLine("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray=CreateRandomArray(m,n,min,max);
// ShowArray(myArray);
// SwapArray(myArray);
// Console.WriteLine();
// ShowArray(myArray);


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {

//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void SwapArray(int[,] array)
// {
//     int buf = 0;
//     int lastRow = array.GetLength(0) - 1;
//     for (int column = 0; column < array.GetLength(1); column++)
//     {
//         buf = array[0, column];
//         array[0, column] = array[lastRow, column];
//         array[lastRow, column] = buf;
//     }

// }

// Задача № 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// Console.WriteLine("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray=CreateRandomArray(m,n,min,max);
// ShowArray(myArray);

// Console.WriteLine();
// ShowArray(SwapArray(myArray));


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {

//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// // заполненеи по столбцам
// int[,] SwapArray (int [,] array)
// {

//     int[,] arrayNew = new int[array.GetLength (0),array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arrayNew[j, i] = array[i,j];
//         }
//     }
//     return arrayNew;
// }


// Задача № 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз втречается элемент входных данных.

// Console.Clear();

// Console.WriteLine("input M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray(m, n, min, max);
// ShowArray(myArray);
// int[] arrayOne = GetOneArray(myArray);
// Console.WriteLine(String.Join(" ", arrayOne));
// SortArray(arrayOne);
// Console.WriteLine(String.Join(" ", arrayOne));
// PrintCoutElement(arrayOne);


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {

//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[] GetOneArray(int[,] arrayTwo)
// {
//     int[] arrayOne = new int[arrayTwo.GetLength(0) * arrayTwo.GetLength(1)];
//     int index = 0;
//     for (int i = 0; i < arrayTwo.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayTwo.GetLength(1); j++)
//         {
//             arrayOne[index] = arrayTwo[i, j];
//             index++;
//         }
//     }
//     return arrayOne;
// }

// void SortArray(int[] array)
// {

//     int buf = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[i] > array[j])
//             {

//                 buf = array[i];
//                 array[i] = array[j];
//                 array[j] = buf;
//             }
//         }
//     }
// }

// void PrintCoutElement(int[] array)
// {
//     int count = 0;
//     int temp = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] != temp)
//         {
//             Console.WriteLine($"{temp} встречается {count} раз");
//             temp = array[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{temp} встречается {count} раз");

// }


