// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*System.Console.WriteLine("Введите число:");
int num = int.Parse(System.Console.ReadLine());

if((uint)num.ToString().Length>3){
    System.Console.WriteLine("Число не допустимо");
}

if((uint)num.ToString().Length<3){
    System.Console.WriteLine("Число не допустимо");}

else {
    int result = (num%100)/10;
    System.Console.WriteLine($"Вторая цифра числа - {result}");
}*/


// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Берем числа до 100000

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


/*System.Console.WriteLine("Введите число:");
int num = int.Parse(System.Console.ReadLine());

if ((uint)num.ToString().Length < 3)
{
    System.Console.WriteLine($"Третьей цифры в числе {num} нет");
}
if ((uint)num.ToString().Length == 3)
{
    int result = (num % 10);
    System.Console.WriteLine($"Третья цифра числа {num} -> {result}");
}
if ((uint)num.ToString().Length > 3)
{
    int result = (num % 1000) / 100;
    System.Console.WriteLine($"Третья цифра числа {num} - {result}");
}*/


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным. 
// Обязательна проверка на ввод числа <1 и >7

// 6 -> да
// 7 -> да
// 1 -> нет

/*System.Console.WriteLine("Введи цифру дня недели:");
int day = int.Parse(System.Console.ReadLine()!);

if (day == 1)
{
    System.Console.WriteLine("День 1 - Понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("День 2 - Вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("День 3 - Среда");
}
else if (day == 4)
{
    System.Console.WriteLine("День 4 - Четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("День 5 - Пятница");
}
else if (day == 6)
{
    System.Console.WriteLine("День 6 - Суббота - ВЫХОДНОЙ");
}
else if (day == 7)
{
    System.Console.WriteLine("День 7 - Воскресенье - ВЫХОДНОЙ");
}

else
{
    System.Console.WriteLine("Нет такого дня недели!");
}
*/





