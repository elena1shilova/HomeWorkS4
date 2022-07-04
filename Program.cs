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
// double AX = Convert.ToInt32(Console.ReadLine());
// double AY = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Впишите координаты точки 2: ");
// double BX = Convert.ToInt32(Console.ReadLine());
// double BY = Convert.ToInt32(Console.ReadLine());
// double CX = (BX-AX)*(BX-AX);
// double CY = (BY-AY)*(BY-AY);
// double result = Math.Sqrt(CX+CY);
// Console.WriteLine(result);
///---------
// Console.Write("Введите число: ");
// double number = Convert.ToInt32(Console.ReadLine());
// Console.Write(number+"=>");
// for (int i = 1; i <= number; i++)
// {
//     double math.pow(i , 2);
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
// double distance(int Ax, int Ay, int Az, int Bx, int By, int Bz)
// {
//     double res = 0;
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
// double dist = distance(Ax, Ay, Az, Bx, By, Bz);
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
