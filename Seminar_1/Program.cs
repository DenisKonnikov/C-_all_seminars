/*/ На вход примимает число и возводит в квадрат

System.Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!); // перевод строки в целочисленное число int.Parse
// математический способ возведения в квадрат 
int sqr = number*number;
// метод библиотеки 
int sqr1 = Convert.ToInt32(Math.Pow(number,2)); // Math.Pow - возведение в квадрат 
// Math.Pow переводит в число double, значит необходимо ковектировать число double в int через Convert.ToInt32
Console.WriteLine(sqr);
Console.WriteLine($"Квадрат числа {number} = {sqr1}");*/

/* На вход принимает число N, а на выходе выводит все целые числа в промежутке от -N до N

System.Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = - number;
while (number1<=number){
    System.Console.Write($"{number1} ");
    number1++;
}*/


/*Задачи семинара:
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет

System.Console.WriteLine("Введите число А");
int number = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите число B");
int number1 = int.Parse(Console.ReadLine()!);

if (Math.Pow(number,2) == number1){
    System.Console.WriteLine($"Число {number1} явлется квадратом числа {number}");
}
else {
    System.Console.WriteLine($"Число {number1} не явлется квадратом числа {number}");
    } */







/*2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница

System.Console.WriteLine("Введите день недели");
int day = int.Parse(Console.ReadLine()!);

if (day == 1){
    System.Console.WriteLine("День недели - Понедельник!");
}

if (day == 2){
    System.Console.WriteLine("День недели - Вторник!");
}

if (day == 3){
    System.Console.WriteLine("День недели - Среда!");
}
if (day == 4){
    System.Console.WriteLine("День недели - Четверг!");
}
if (day == 5){
    System.Console.WriteLine("День недели - Пятница!");
}
if (day == 6){
    System.Console.WriteLine("День недели - Суббота!");
}
if (day == 7){
    System.Console.WriteLine("День недели - Воскресенье!");
};*/

/*3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8

System.Console.WriteLine("Введите  число");
int num = int.Parse(Console.ReadLine()!);

int num1 = num % 10;
System.Console.WriteLine($"Последняя цифра числа {num} = {num1}");

// или 

System.Console.WriteLine($"Последняя цифра числа {num} = {Convert.ToInt32(num % 10)}");*/





