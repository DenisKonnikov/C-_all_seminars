// Программа, которая выводит случайное трехзначное число и удаляет вторую ифру этого числа

/*int number = new Random().Next(100, 1000);

int result = (number / 100) * 10 + number % 10;
System.Console.WriteLine($"{number} -> {result}");*/



/*1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.*/

/*int number = new Random().Next(10, 99);

int num1 = number / 10;
int num2 = number % 10;
if (num1>num2)
{
    System.Console.WriteLine($" Случайное число {number}. Первая цифра {num1} болше второй {num2}");

}

else
{
    System.Console.WriteLine($"лучайное число {number}. Вторая цифра {num2} больше первой {num1}");
}
*/


/* 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
  Если второе число не кратно числу первому, то программа выводит остаток от деления. */

/*System.Console.WriteLine("Введите первое число А:");
int number = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число B:");
int number1 = int.Parse(Console.ReadLine());

if (number%number1 == 0){
    System.Console.WriteLine($"Число {number} кратно {number1}");
}
else {
    System.Console.WriteLine($"Остаток от деления {number%number1}");
}*/



/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
 
14  ->  нет 
46  ->  нет 
161 ->  да 

System.Console.WriteLine("Введите число А");
int num1 = int.Parse(System.Console.ReadLine());
if (num1 % 7 == 0 && num1 % 21 == 0)
{
    Console.WriteLine($"Число {num1} кратно 7 и 21");
}
else
{
    System.Console.WriteLine("Число не кратно");
}*/


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*System.Console.WriteLine("Введите число А");
int num1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Введите число А");
int num2 = int.Parse(System.Console.ReadLine());

if(Math.Pow(num2,2) == num1 || Math.Pow(num1,2) == num2){
    System.Console.WriteLine($"Одно число является квадратом другого");
}
else {
    System.Console.WriteLine($"Число не является квадратом другого");
}*/


