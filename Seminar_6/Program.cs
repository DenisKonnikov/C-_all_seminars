/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
//РАЗВОРОТ МАССИВА


// int[] array = GetArray(10, 0,20);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] resultArray = ReversArray2(array);
// Console.WriteLine($"[{String.Join(", ", resultArray)}]");

// ReversArray1(array);
// Console.WriteLine($"[{String.Join(", ", resultArray)}]");

// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i<size; i++){
//         res[i] = new Random().Next(minValue, maxValue+1);
//     }
//     return res;
// }

// void ReversArray1(int[] array){
//     for(int i=0; i < array.Length; i++){
//         int k = array[i];
//         array[i] = array[array.Length-i-1];
//         array[array.Length-i-1]=k;
//     }

// }

// int[] ReversArray2(int[] array){
//    int [] result = new int[array.Length];
//    for(int i = 0; i <array.Length; i++){
//     result[i] = array[array.Length-i-1];

//    }

// return result;
// }


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


/* Console.WriteLine("Введите число 1:");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2:");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2:");
int c = int.Parse(Console.ReadLine()!);

if (Triangle(a,b,c) == true){
    Console.WriteLine("Это треугольник");
    }
    else {
        Console.WriteLine("Это НЕ треугольник");
    }
    
bool Triangle(int A, int B, int C ){
    if(A < (B+C) && B <(A+C) && C < (A+B)){
        return true;
    }
    else {
        return false;
    }
}

// решение 2 
Console.WriteLine("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число 3: ");
int C = int.Parse(Console.ReadLine()!);

if((A > 0 && B > 0 && C > 0) || (A < B + C && B < A + C && C < A + B)) {
    Console.WriteLine("Такой треугольник возможен");}

else {Console.WriteLine("Такой треугольник невозможен");}
*/

// Опрделить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

//Решение 1

/*Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;

if (HappyNumber(number) == true){
    Console.WriteLine("Это счастливое число");
    }
    else {
        Console.WriteLine("Это НЕ счастоивое число");
    }

bool HappyNumber (string number){
int sum1=0;
int sum2=0;
{
    for(int i = 0; i<number.Length/2; i++){
        sum1 += Convert.ToInt32(Convert.ToString(number[i]));
        sum2 += Convert.ToInt32(Convert.ToString(number[number.Length-1-i]));
    }
    if(sum1==sum2){
        return true;
    }
    else{
        return false;
    }
}
}*/

//Решение 2



/*Console.WriteLine("Введите число: ");
string number = Console.ReadLine()!;
HappyNumber(number);

void HappyNumber (string number){
int sum1=0;
int sum2=0;
{
    for(int i = 0; i<number.Length/2; i++){
        sum1 += Convert.ToInt32(Convert.ToString(number[i]));
        sum2 += Convert.ToInt32(Convert.ToString(number[number.Length-1-i]));
    }
    if(sum1==sum2){
        Console.WriteLine("Это счастливое число");
    }
    else{
        Console.WriteLine("Это НЕ счастоивое число");
    }
}
}*/

// Решение 3

/*Console.WriteLine("Введите шестизначное число: ");
string X = (Console.ReadLine()!);
int size = X.Length;
if(size != 6) System.Console.WriteLine("Число не шестизначное");
else Check(X);

//-------------

void Check(string X)

{
int Sum1 = 0;
int Sum2 = 0;

int i = 0;
while(i<size/2)
{Sum1 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
while(i<size)
{Sum2 += Convert.ToInt32(Convert.ToString(X[i]));
i++;}
if(Sum1 == Sum2) {System.Console.WriteLine("Это счастливое число");}
else {System.Console.WriteLine("Это не счастливое число");}
}
*/


//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
//Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"[{String.Join(", ", Fibonachy(N))}]");


int[] Fibonachy(int N)
{
    int[] Fib = new int[N];
    Fib[0] = 0;
    Fib[0] = 1;
    for (int i = 2; i < N; i++)
    {
        Fib[i] = Fib[i - 1] + Fib[i - 2];
    }
    return Fib;
}
