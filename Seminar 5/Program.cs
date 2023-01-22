// See https://aka.ms/new-console-template for more information

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

/* int[] array = GetArray(12, -9,9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    if (element > 0){
        positiveSum =  positiveSum + element;
    }
    else {
        negativeSum = negativeSum + element;
    }
}

Console.WriteLine($"сумма положительных равна {positiveSum}, сумма отрицательных равна {negativeSum}");

// Метод (универсальный метод заполнения массива)

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for (int i = 0; i<size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}*/
//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] // массив не менее 5ти символов


/*int[] Array = GetArray(30);
Console.WriteLine($"[{String.Join(", ", Array)}]");
for (int i = 0; i < Array.Length; i++)
{
    Array[i] = Array[i] * (-1);
}

Console.WriteLine($"[{String.Join(", ", Array)}]");

// Method 

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}
*/

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//Задайте массив. Напишите программу, которая определяет,присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// В этом решении проверяется каждая строка и выводит в терминале "НЕ найдено"

// int[] Array = GetArray(10); 

// int find = -5;
// foreach (int ArrayEl in Array)
// {
//     if (ArrayEl == find)
//     {
//         Console.WriteLine($"Число найдено");
//     }
//     else {
//         Console.WriteLine($"Число НЕ найдено");
//     }
// }

// Method1 

// int[] GetArray(int size) // 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
//     return array;
// }


// Решение 2 через boll 

// int[] Array = GetArray(10); 
// int Find = -5;
// Console.WriteLine($"[{String.Join(", ", Array)}]");

// if (FindElement(Array, Find)){
//     Console.WriteLine($"Число найдено");
// }
// else {
//      Console.WriteLine($"Число  НЕ найдено");
// }

// bool FindElement (int[] Array, int Find){
// foreach (int ArrayEl in Array)
// {
//     if (ArrayEl == Find){
//         return true;
//     }

// }
// return false;
// }


// // Method2 

// int[] GetArray(int size) 
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-10, 10);
//     }
//     return array;
// }


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].


int[] Array= GetArray(123);

// Method

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

Console.WriteLine($"[{String.Join(", ", Array)}]");
int count = 0;
for (int i = 0; i<=122; i++){

if (Array[i]>=10 && Array[i]<100){
    count = count +1;
}
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] {count}");



/*int[] Array = GetArray(123);
Console.WriteLine($"[{String.Join(",", Array)}]"!);
Console.WriteLine($"Количество элементов от 10 до 99 в массиве {Quantity(Array)}");

// -----------Method 
int[] GetArray(int size){
    int [] res = new int[size];
    for(int i=0; i<size; i++){
    res[i] = new Random().Next(0, 10);

    }
return res;
}

int Quantity(int [] Array){
    int count = 0;
    foreach (int element in Array){
        if(10 <=element && element <100)
        {count++;}
    }
    return count;
}*/