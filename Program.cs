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