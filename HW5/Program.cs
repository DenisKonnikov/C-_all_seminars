// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

/*int[] numbers = GetArray(30);
Console.WriteLine($"[{String.Join(",", numbers)}]");
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чиснл из массива {count}");

int[] GetArray(int size) // 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


/*int[] numbers = GetArray(30);
Console.WriteLine($"[{String.Join(",", numbers)}]");
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if(i%2==1){
        result = result + numbers[i];
    }  
}
Console.WriteLine($"Сумма чисел в четных индексах {result}");

int[] GetArray(int size) // 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(50);
    }
    return array;

}
*/

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] Array = GetArray(5);
Console.WriteLine($"[{String.Join(", ", Array)}]");
int result = Result(Array);
int LengthArray = Array.Length;


int[] resultArray = GetArray2(result, LengthArray);
Console.WriteLine($"[{String.Join(", ", resultArray)}]");

int[] GetArray2(int result, int LengthArray)
{
int[] FinalArray = new int[result];
    if(LengthArray % 2 == 0)
    {for(int i = 0; i < result; i++) 
    {
        FinalArray[i] = Array[i] * Array[LengthArray - (i + 1)];
    }
    }
    else 
    {
    {for(int i = 0; i < result-1; i++)
    {FinalArray[i] = Array[i]* Array[LengthArray - (i + 1)];}
    }
    FinalArray[result-1] = Array[result-1];
    }
    return FinalArray;
}


//---------
int[] GetArray(int size)  
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,10);
    }
    return array;
}
//----------
int Result(int[] Array){
    int result1=0;
    if (Array.Length%2==1){
        result1 = Array.Length/2 +1;
    }
    else{
        result1 = Array.Length/2;
    }
    return result1;
}



// int[] ResultArray(int ResultArraySize, int Array3Length)
// {   
//     int[] FinalArray = new int[ResultArraySize];
//     if(Array3Length % 2 == 0)
//     {for(int i = 0; i < ResultArraySize; i++) 
//     {
//         FinalArray[i] = Array3[i] * Array3[Array3Length - (i + 1)];
//     }
//     }
//     else 
//     {
//     {for(int i = 0; i < ResultArraySize-1; i++)
//     {FinalArray[i] = Array3[i]* Array3[Array3Length - (i + 1)];}
//     }
//     FinalArray[ResultArraySize-1] = Array3[ResultArraySize-1];
//     }
//     return FinalArray;
// }