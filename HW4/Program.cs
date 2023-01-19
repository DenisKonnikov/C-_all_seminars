// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
// (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B:");
// int B = int.Parse(Console.ReadLine()!);
// int result = Ndegree(A,B);
// Console.WriteLine($"Число А в натуральной степени B равна {(result)}");
// //------Method------

// int Ndegree (int A, int B){
//     int degree=1;
//     for(int i=1; i <=B; i++) {
//         degree = degree*A;
//     }
// return degree;
// }



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"сумма всех цифр в числе = {Sum(A)}");
// //----Method

int Sum(int A)
{
    if ((uint)A.ToString().Length == 2)
    {
        int sum1 = (A / 10) + A % 10;
    }

    if ((uint)A.ToString().Length > 2)
    {
        int sum1 = ((A / 100) + ((A % 100) * 10) + A % 10); 
    }
    return sum1;
}

// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"сумма всех цивр в числе = {(A%100)/10}");


/*Console.WriteLine("введите число:");
string number = Console.ReadLine()!;
Console.Write($"Количество чисел равна {GetQuantity(number)} ");

// ---------method---------

int GetQuantity(string A){
    int Quantity = A.Length;
    return Quantity;
}
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

/*int[] Array = GetArray(8);
Console.Write($"[{String.Join(",",Array)}]");
//Metod
int[] GetArray (int size){
     int[] Array = new int[size];
     for(int i=0;i<size; i++){
        Array[i]=new Random().Next(99);
     }
     return Array;
     }*/