//SEMINAR1
// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine()); ;
// if (numberA > numberB)
// {
//     Console.WriteLine("Большее число =>" + numberA);
//     Console.WriteLine("Меньшее число =>" + numberB);
// }
// else
// {
//     Console.WriteLine("Большее число =>" + numberB);
//     Console.WriteLine("Меньшее число =>" + numberA);
// }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int numberC = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if(numberA>numberB&&numberA>numberC) max = numberA;
// else if(numberB>numberA&&numberB>numberC) max = numberB;
// else max = numberC;
// Console.WriteLine("Максимальное число из трех => " + max);


// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA%2==0) Console.WriteLine("Число "+numberA+ " четное");
// else Console.WriteLine("Число "+numberA+" нечетное");


// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Console.WriteLine("Введите число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Все четные числа до " + numberA + " => ");
// for (int i = 2; i <= numberA; i += 2)
// {
//     Console.Write(i + " ");
// }

//------------------------------------------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------------------------------------------

//SEMINAR2
// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Введите трехзначное число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA<=99) Console.WriteLine(numberA + " => не трехзначное число");
// else if(numberA>=1000) Console.WriteLine(numberA + " => не трехзначное число");
// else Console.WriteLine(numberA/10%10);
//---------решение через методы-----------
// void Number2(){
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA<=99) Console.WriteLine(numberA + " => не трехзначное число");
// else if(numberA>=1000) Console.WriteLine(numberA + " => не трехзначное число");
// else Console.WriteLine(numberA/10%10);
// }
// Console.WriteLine("Введите трехзначное число ");
// Number2();

// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.WriteLine("Введите число: ");
// long numberA = Convert.ToInt64(Console.ReadLine());
// if (numberA <= 99) Console.WriteLine("В числе " + numberA + " третьей цифры нет!");
// else
// {
//     Console.Write("Третья цифра числа " + numberA + " => ");
//     for (long i = 0; numberA >= 1000; i++)
//     {
//         numberA = numberA / 10;
//     }
//     Console.WriteLine(numberA % 10);
// }
//---------решение через методы-----------
// void Number3()
// {
//     long numberA = Convert.ToInt64(Console.ReadLine());
//     if (numberA <= 99) Console.WriteLine("В числе " + numberA + " третьей цифры нет!");
//     else
//     {
//         Console.Write("Третья цифра числа " + numberA + " => ");
//         for (long i = 0; numberA >= 1000; i++)
//         {
//             numberA = numberA / 10;
//         }
//         Console.WriteLine(numberA % 10);
//     }
// }
// Console.WriteLine("Введите число: ");
// Number3();

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("Введите цифру дня недели: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// if(numberA<=0||numberA>=8) Console.WriteLine(numberA + " это не день недели!");
// else if(numberA==6||numberA==7) Console.WriteLine("Ура, выходной!!!");
// else Console.WriteLine(numberA + " => рабочий день недели.");
//---------решение через методы-----------
// void Dey()
// {
//     int numberA = Convert.ToInt32(Console.ReadLine());
//     if (numberA <= 0 || numberA >= 8) Console.WriteLine(numberA + " это не день недели!");
//     else if (numberA == 6 || numberA == 7) Console.WriteLine("Ура, выходной!!!");
//     else Console.WriteLine(numberA + " => рабочий день недели.");
// }
// Console.WriteLine("Введите цифру дня недели: ");
// Dey();


// int[] Input()
//             {
//                 int[] Array = new int[2];
//                 Console.WriteLine("Введите координату Х");
//                 int x = Convert.ToInt32(Console.ReadLine());
//                 Array[0] = x;
//                 Console.WriteLine("Введите координату У");
//                 int y = Convert.ToInt32(Console.ReadLine());
//                 Array[1] = y;
//                 return Array;
//             }
//             int[] mini = Input();
//             while (mini[0] == 0 || mini[1] == 0)
//             {
//                 Console.WriteLine("Точка находится на оси");
//                 mini = Input();
//             }

//             if (mini[0] > 0 && mini[1] > 0)
//             {
//                 Console.WriteLine("Точка находится в первой четверти");
//             }

//             else if (mini[0] < 0 && mini[1] < 0)
//             {
//                 Console.WriteLine("Точка находится в третьей четверти");
//             }

//             else if (mini[1] < 0 && mini[0] > 0)
//             {
//                 Console.WriteLine("Точка находится в четвертой четверти");
//             }

//             else
//             {
//                 Console.WriteLine("Точка находится во второй четверти");
//             }

// Console.WriteLine("Введите четверть: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
//--------
// if(numberA == 1) {
//     Console.WriteLine("x>0 " + "y>0");
// }
// else if(numberA == 2) {
//     Console.WriteLine("x<0 " + "y>0");
// }
// else if(numberA == 3) {
//     Console.WriteLine("x<0 " + "y<0");
// }
//     else if(numberA == 4){
//     Console.WriteLine("x>0 " + "y<0");
// }
// else Console.WriteLine("Данной четверти не существует!");
//-------
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Console.WriteLine("Впишите координаты точки 1: ");
// int AX = Convert.ToInt32(Console.ReadLine());
// int AY = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Впишите координаты точки 2: ");
// int BX = Convert.ToInt32(Console.ReadLine());
// int BY = Convert.ToInt32(Console.ReadLine());
// int CX = (BX-AX)*(BX-AX);
// int CY = (BY-AY)*(BY-AY);
// int result = Math.Sqrt(CX+CY);
// Console.WriteLine(result);
///---------
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number+"=>");
// for (int i = 1; i <= number; i++)
// {
//     int math.pow(i , 2);
//     Console.Write(sum+" ");
// }

//SEMINAR3
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// int[] newArray(int length)//объявляем массив
// {
//     int[] array = new int[length];//создаем новый массив array с типом int и длинной, заданной за пределами метода
//     return array;//возвращаем новый массив
// }
// int[] fillArray(int[] array)//заполняем массив, создаем метод, который вернет нам массив
// {
//     Console.WriteLine("Введите число: ");
//     int numberA = Convert.ToInt32(Console.ReadLine());// просим пользователя в консоли ввести значение
//     for (int i = 0; i < array.Length; i++)//пока i < длины массива
//     {
//         array[i] = numberA % 10; //записываем остаток от деления на 10 в текущий индекс массива
//         numberA = numberA / 10;//перебираем число по цифрам путем деления на 10
//                                //    Console.Write($"{array[i]} ");
//     }
//     return array;//возвращаем заполненный массив
// }
// int palindArray(int[] array)//создаем метод, в который отправим массив и заберем результат после сравнения
// {
//     int len = array.Length;
//     int test = 0;
//     if (array[0] == array[4] && array[1] == array[3]) test = 1;
//     else test = 2;
//     return test;
// }
// int[] array = newArray(5);//передаем, что в массиве будет пять значений
// fillArray(array);//запускаем 2 метод, в данном случае заданное число разбиваем на значения массива
// int palindrom = palindArray(array);
// if (palindrom == 1) Console.WriteLine("Палиндром!");
// else Console.WriteLine("Не является палиндромом!");
//---------------
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//A(xa, ya, za) и B(xb, yb, zb)
//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
// int distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
// {
//     int res = 0;
//     res = Math.Round(Math.Sqrt((Bx-Ax)*(Bx-Ax)+(By-Ay)*(By-Ay)+(Bz-Az)*(Bz-Az)),2);
//     return res;
// }
// Console.WriteLine("Введите координаты первой точки (1): ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты первой точки (2): ");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты первой точки (3): ");
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки (1): ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки (2): ");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки (3): ");
// int Bz = Convert.ToInt32(Console.ReadLine());
// int dist = distance(Ax, Ay, Az, Bx, By, Bz);
// Console.WriteLine(dist);
//--------------
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// void tableCube(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write(i*i*i+" ");
//     }
// }
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// tableCube(num);
//-----------
// void sum_numbers(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum = sum + i;
//     }
//     Console.WriteLine(num + "->" + sum);
// }


// for (int i = 0; i < 5; i++)
// {
// Console.WriteLine("Ввод числа N");
// int N = Convert.ToInt32(Console.ReadLine());
// sum_numbers(N);

// }

//----
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] RandomArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         RandomArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);

//SEMINAR4
// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// int naturalDegree(int numA, int numB)
// {
//     return Math.Pow(numA, numB);
// }
// Console.Write("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{A}^{B} -> " + naturalDegree(A,B));
//-----
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// int sumMethod(int numA)
// {
//     int sum = 0;
//     while (numA > 0)
//     {
//         sum = sum + numA % 10;
//         numA = numA / 10;
//     }
//     return sum;
// }
// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {A} -> {sumMethod(A)}");
//----------
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// int[] newArray(int length, int min, int max)
// {
//     int[] array = new int[length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i]=new Random().Next(min,max+1);
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

// Console.Clear();
// Console.Write("Введите минимальное число для диапазона: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число для диапазона: ");
// int max = Convert.ToInt32(Console.ReadLine());
// // newArray(8,min,max);
// Console.Write($"Массив с диапозоном от {min} до {max} -> ");
// int[] myArray = newArray(8,min,max);
// ShowArray(myArray);
// Примеры форматирования

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0}  Возраст: {1}", name, age);

// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// int number2 = 45.08;
// nt x = 7;
// int y = 8;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Елена";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
// Console.WriteLin


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);
// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

//SEMINAR5
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// int[] newArray(int length)
// {
//     int[] arr = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//          arr[i] = new Random().Next(100,1000);
//     }
// return arr;   

// }
// void number(int[] arr)
// {
//     int count = 0;
//     Console.Write("В массиве среди случайных трехзначных чисел: ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//         if(arr[i]%2==0) count++;
//     }
//     Console.Write($" - четных -> {count} ");
// }
// int[] array = newArray(4);
// number(array);
//------
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] newArray(int length, int start, int end)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(start, end + 1);
//     }
//     return array;
// }
// void sumNumber(int[] array)
// {
//     Console.Write("Сумма чисел на нечетных позициях массива чисел: ");
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//         if(i%2!=0) sum += array[i];
//     }
//     Console.Write($"= {sum}");
// }
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int[] arr = newArray(4, number1, number2);
// sumNumber(arr);
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// int[] newArray(int length, int number1, int number2)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = Math.Round(new Random().Next(number1,number2) + new Random().Nextint(), 2);
//         // Console.Write($"{array[i]} ");
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + "; ");
//     }
//     Console.WriteLine();
// }
// int minNumber(int[] array)
// {
//     int min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]<min) min = array[i];
//     }
//     return min;
// }
// int maxNumber(int[] array)
// {
//     int max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]>max) max = array[i];
//     }
//     return max;
// }
// void result(int min, int max)
// {
//     Console.Write(Math.Round(min - max, 2));
// }
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[] arr =  newArray(4, number1, number2);
// Console.Write($"В диапазоне чисел от {number1} до {number2} получаем массив: " );
// ShowArray(arr);
// int min = minNumber(arr);
// int max = maxNumber(arr);
// Console.Write($"Разница между максимальным {max} и минимальным {min} значениями = ");
// result(max, min);

//SEMINAR6
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// int[] numbersInput(int M){
//         int[] newArray = new int[M];
//         for (int i = 0; i < M; i++)
//         {
//              Console.WriteLine($"Введите число {i+1}: ");   
//              newArray[i] = Convert.ToInt32(Console.ReadLine());  
//         }
//         return newArray;
// }
// void arrayPrint(int[] array){
//         for (int i = 0; i < array.Length; i++)
//         {
//                 Console.Write($"{array[i]} ");
//         }
//         Console.WriteLine();
// }
// int numberCount(int[] array){
//         int count = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//                 if(array[i]==0) count++;                       
//         }
//         return count;
// }
// Console.WriteLine("Введите количество чисел: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = numbersInput(M);
// arrayPrint(array);
// int count = numberCount(array);
// Console.WriteLine($"Среди введенных пользователем чисел количество '0' => {count}");
//----------
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// void number_x(int k1, int b1, int k2, int b2){
//         if(k1==k2&&b1==b2) Console.WriteLine("Прямые совпадают!");
//         else if (k1==k2) Console.WriteLine("Прямые не пересекаются!");
//         else{
//                 int x = (b2-b1)/(k1-k2);
//                 int y1 = k1*x + b1;
//                 int y2 = k2*x+b2;
//                 Console.WriteLine($"y1 => {y1}, y2 => {y2}");
//         }
// }
// Console.Write("Введите значение b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// number_x(k1, b1, k2, b2);

//SEMINAR7
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9   
// double[,] two_dimensional_array(int m, int n)
// {
//     double[,] array = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = Math.Round((new Random().Next(-100, 101) +
//             new Random().NextDouble()), 2);
//         }
//     }
//     return array;
// }
// void arrayPrint(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} |");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = two_dimensional_array(m, n);
// arrayPrint(array);
//---------
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// void number_array(int[,] array, int n, int m){
//         if(n<3&&m<4) Console.WriteLine(array[n, m]);
//         else Console.WriteLine($"[{n}, {m}] => такого числа в массиве нет");
// }
// int[,] array = {
//         {1, 4, 7, 2},
//         {5, 9, 2, 3},
//         {8, 4, 2, 4}
// };
// Console.Write("Введите номер строки в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());
// number_array(array, n, m);
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int[,] two_dimensional_array(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// void arrayPrint(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} |");
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }
// void arithmetic_mean(int[,] array, int m, int n)
// {
//     double summ = 0;
// //     int j = 0;
//     for (int j = 0; j < n; j++)
//     {
//         summ = 0;
//         for (int i = 0; i < m; i++)
//         {

//             summ = summ + array[i, j]; 
//         }
//         Console.WriteLine($"Среднее арифметическое {j+1} столбца => {Math.Round(summ/m, 1)} ");
//     }
// }
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = two_dimensional_array(m, n);
// arrayPrint(array);
// arithmetic_mean(array, m, n);
//------------
// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -50 до 50. Вычисляется и выводится: а) среднее
// арифметическое отрицательных чисел в каждой строке; в) сумма и среднее
// арифметическое положительных четных чисел в каждой строке; д) сумма и
// среднее арифметическое всех чисел.
// int[,] array2(int n, int m){
//         int[,] array2 = new int[n, m];
//         for (int i = 0; i < array2.GetLength(0); i++)
//         {
//                 for (int j = 0; j < array2.GetLength(1); j++)
//                 {
//                         array2[i, j] = new Random().Next(-50, 51);
//                 }
//         }
//         return array2;
// }
// void printArray(int[,] array){
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                         Console.Write($"{array[i, j]}| ");
//                 }
//                 Console.WriteLine();
//         }
// }
// double average(int[,] array, int n, int m){
//         Console.Write("1)");
//         double averages = 0;
//         int count = 0;
//         for (int i = 0; i < n; i++)
//         {
//                 averages = 0;
//                 count = 0;
//                 for (int j = 0; j < m; j++)
//                 {

//                         if(array[i, j]<0){ 
//                         averages = averages + array[i, j];
//                         count++;
//                         }
//                         else if(array[i, j]==0) count=1;
//                 }
//                 if(count==0) count++;
//                 Console.WriteLine($"Среднее арифметическое отрицательных чисел в строке {i+1} => {Math.Round(averages/count, 1)}");

//         }
//         return averages;
// }
// double average2(int[,] array, int n, int m){
//         Console.Write("2)");
//         double averages = 0;
//         int count = 0;
//         for (int i = 0; i < n; i++)
//         {
//                 averages = 0;
//                 count = 0;
//                 for (int j = 0; j < m; j++)
//                 {

//                         if(array[i, j]>0){ 
//                         averages = averages + array[i, j];
//                         count++;
//                         }

//                 }
//                 if(count==0) count++;
//                 Console.WriteLine($"Сумма положительных чисел в строке {i+1} => {averages}");
//                 Console.WriteLine($"Среднее арифметическое положительных чисел в строке {i+1} => {Math.Round(averages/count, 1)}");
//         }
//         return averages;
// }
// double average3(int[,] array, int n, int m){
//         Console.Write("3)");
//         double averages = 0;
//         int count = 0;
//         for (int i = 0; i < n; i++)
//         {
//                 averages = 0;
//                 count = 0;
//                 for (int j = 0; j < m; j++)
//                 {

//                         averages = averages + array[i, j];
//                         count++;

//                 }

//                 Console.WriteLine($"Сумма всех чисел в строке {i+1} => {averages}");
//                 Console.WriteLine($"Среднее арифметическое всех чисел в строке {i+1} => {Math.Round(averages/count, 1)}");
//         }
//         return averages; 
// }
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] array2new = array2(n, m);
// printArray(array2new);
// average(array2new, n, m);
// average2(array2new, n, m);
// average3(array2new, n, m);
//----------
// Формируется и выводится прямоугольный массив - таблица умножения двух
// чисел от 1 до 10.
// int[,] newArray(){
//         int[,] array = new int[10, 10];
//         for (int i = 1; i < 2; i++)
//         {
//                 for (int j = 1; j < 10; j++)
//                 {
//                         array[i, j] = j;
//                 }

//         }
//         for (int j = 1; j < 2; j++)
//         {
//                 for (int i = 1; i < 10; i++)
//                 {
//                         array[i, j] = i;
//                 }

//         }
//         return array;
// }
// void printArray(int[,] array){
//         for (int i = 1; i < array.GetLength(0); i++)
//         {
//                 for (int j = 1; j < array.GetLength(1); j++)
//                 {
//                        Console.Write("{0,4} |", array[i, j]);


//                 }
//                 Console.WriteLine();
//         }
// }
// int[,] multiplication_table(int[,] array){
//         for (int i = 2; i < array.GetLength(0); i++)
//         {
//                 for (int j = 2; j < array.GetLength(1); j++)
//                 {
//                         array[i, j] = i*j;
//                 }
//         }
//         return array;
// }
// int[,] arrayMy = newArray();
// multiplication_table(arrayMy);
// printArray(arrayMy);

//SEMINAR8
// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
// int[,] newArray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 101);
//         }
//     }
//     return array;
// }
// void printArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,4} |", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// int[,] arrayOrder(int[,] array, int n, int m)
// {

//     for (int i = 0; i < n; i++)
//     {
//         int min = array[i, 0];
//         int minIn = 0;
//         int count = 0;
//         int temp = 0;
//         while (count < m)
//         {
//             min = array[i, count];
//             for (int j = count; j < m; j++)
//             {

//                 if (array[i, j] < min)
//                 {
//                     min = array[i, j];
//                     minIn = j;
//                     temp = array[i, count];
//                     array[i, count] = array[i, minIn];
//                     array[i, minIn] = temp;
//                 }
//             }
//             count++;

//         }
//     }
//     return array;
// }
// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] arr = newArray(n, m);
// Console.WriteLine("Двумерный массив с рандомными числами от 1 до 100: ");
// printArray(arr);
// Console.WriteLine();
// Console.WriteLine("Упорядоченный двумерный массив по каждой строке с рандомными числами от 1 до 100: ");
// int[,] arr1 = arrayOrder(arr, n, m);
// printArray(arr1);
//------
// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int[,] newArray(int m){
//     int[,] array = new int[m,m];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,11);
//         }
//     }
//     return array;
// }
// void printArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,4}|", array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// int[] sumArray(int[,] array, int m){
//     int[] arr1 = new int[m];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int summ = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             summ = summ + array[i,j];
//         } 
//         arr1[i] = summ;
//         Console.WriteLine($"Сумма строки {i+1} -> {arr1[i]} ");
//     }

//     return arr1;
// }
// void maxSumm(int[] array){
//     int min = array[0];
//     int minIn = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]<min) {
//             min = array[i];
//             minIn = i;
//     }
//     }
//     Console.WriteLine();
//     Console.Write($"Наименьшую сумму имеет строка -> {minIn+1}.");
// }
// Console.Write("Введите размер прямоугольного двумерного массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] arr1 = newArray(m);
// printArray(arr1);
// int[] arr2 = sumArray(arr1, m);
// maxSumm(arr2);
//-----
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
// int[,] arrNew1(int m){
//     int[,] arr = new int[m,m];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 11);
//         }
//     }
//     return arr;
// }
// void printArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0,4} |", array[i,j]);
//         }
//         Console.WriteLine();
//     }
// }
// int[,] workArray(int[,] arr1, int[,] arr2, int m){
//     int[,] arr3 = new int[m,m];
//     for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr1.GetLength(1); j++)
//         {
//             arr3[i,j] = arr1[i,j]*arr2[i,j];
//         }        
//     }
//     return arr3;
// }
// Console.Write("Введите количество строк и столбцов двух матриц: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] arr1 = arrNew1(m);
// int[,] arr2 = arrNew1(m);
// Console.WriteLine("Первая матрица: ");
// printArray(arr1);
// Console.WriteLine();
// Console.WriteLine("Вторая матрица: ");
// printArray(arr2);
// int[,] work = workArray(arr1, arr2, m);
// Console.WriteLine("произведение двух матриц: ");
// printArray(work);
//------
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
// Console.Write("введите размеры через пробел: ");
// string[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(nums[2])}, 10, 99);
// PrintArray(array);

// int[,,] GetArray(int[] sizes, int min, int max)
// {
//     int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k<result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max+1);
//                 if(FindElement(result,element)) continue;
//                 result[i,j,k] = element;
//                 k++;
//             }
//         }
//     }   
//     return result;
// }

// bool FindElement(int[,,] array, int el)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if(array[i,j,k]==el) return true;
//             }
//         }   
//     }
//     return false;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]} ({i}, {j}, {k}) ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
//-----------------
// Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
// Console.Write($"Введите размер матрицы: ");
// int s = int.Parse(Console.ReadLine());
// int[,] arr = GetArray(s);
// printArray(arr);

// int[,] GetArray(int size)
// {
//     int[,] result = new int[size, size];
//     int i = 0;
//     int j = 0;
//     int rowE = size - 1;
//     int columnE = size - 1;
//     int rowS = 0;
//     int columnS = 0;
//     bool left = true;
//     bool top = true;
//     int count = 0;
//     while (count < size*size)
//     {
//         count++;
//         result[i,j] = count;
//         if (left&&top)
//         {
//             if(j==columnE)
//             {
//                 rowS++;
//                 top = true;
//                 left = false;
//                 i++;
//                 continue;
//             }
//             else
//             {
//                 j++;
//                 continue;
//             }
//         }
//         if(!left&&top)
//         {
//             if(i==rowE)
//             {
//                 columnE--;
//                 top = false;
//                 left = false;
//                 j--;
//                 continue;
//             }
//             else
//             {
//                 i++;
//                 continue;
//             }
//         }
//         if(!left&&!top)
//         {
//             if(j==columnS)
//             {
//                 rowE--;
//                 top = false;
//                 left = true;
//                 i--;
//                 continue;
//             }
//             else
//             {
//                 j--;
//                 continue;
//             }
//         }
//         if(left&&!top)
//         {
//             if(i==rowS)
//             {
//                 columnS++;
//                 top = true;
//                 left = true;
//                 j++;
//                 continue;
//             }
//             else
//             {
//                 i--;
//                 continue;
//             }
//         }
//     }
//     return result;
// }
// void printArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }