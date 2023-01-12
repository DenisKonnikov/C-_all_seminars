//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*Console.Write("Введи число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

//--------------Методы-----------------
int GetSum (int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum = sum + i; // sum += i
    }
    return sum;
}
*/



// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

/*System.Console.WriteLine("введите число:");
int A = int.Parse(Console.ReadLine()!);
System.Console.WriteLine($"Произведение чисел равна {GetFactorial(A)} ");


//----------Методы-------------
int GetFactorial(int A){
    int factorial = 1;
    for(int i =1; i<=A; i++){
        factorial=factorial*i;
    }
    return factorial;
}*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5


/*Console.WriteLine("введите число:");
int number = int.Parse(System.Console.ReadLine()!);
Console.Write($"Количество чисел равна {GetQuantity(number)} ");

//-----метод--------

int GetQuantity (int A){
    int Quantity=0;
    if (A == 0){
        return 1;
    }
     
    while(A>0){
        Quantity=Quantity+1; A=A/10;
    }
return Quantity;
}*/

/*Console.WriteLine("введите число:");
string number = Console.ReadLine();
Console.Write($"Количество чисел равна {GetQuantity(number)} ");

// ---------method---------

int GetQuantity(string number){
    int Quantity = number.Length;
    return Quantity;
}*/


/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0]*/

int[] Array = GetArray(8);
Console.Write($"[{String.Join(",",Array)}]");

int[] GetArray (int size){
     int[] Array = new int[size];
     for(int i=0;i<size; i++){
        Array[i]=new Random().Next(2);
     }
     return Array;
     }


