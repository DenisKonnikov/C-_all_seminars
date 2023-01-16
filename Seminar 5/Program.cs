// See https://aka.ms/new-console-template for more information

/*int[] Array = GetArray(6);
Console.WriteLine($"[{String.Join(",", Array)}]"!);
int[] Array2 = Channge(Array);
Console.WriteLine($"[{String.Join(",", Array2)}]"!);

//-------Методы

int[] GetArray(int size){
    int [] res = new int[size];
    for(int i=0; i<size; i++){
        ReferenceEquals[i] = new Random().Next(-1000,1000);

    }
return res;
}
 
int [] Channge(int[] Array)
{
    foreach(int item = 0; i<Array.Length; i++)
{
    Array[item]=  -Array[item];
}
return Array;
}*/



/*int [] Array = GetArray(5);
Console.WriteLine($"[{String.Join(",", Array)}]"!);
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
if(FindNumber(number, Array))
{Console.WriteLine($"число {number} есть в массиве");}
else 
{Console.WriteLine($"число {number} нет в массиве");}

//-----Methood

int[] GetArray(int size){
    int [] res = new int[size];
    for(int i=0; i<size; i++){
    res[i] = new Random().Next(20);

    }
return res;
}*/

/*bool FindNumber(int number, int[]Array){
    foreach(int i in Array){
        if(i==number)
        return true;
        
    }
return false;

}*/

/*int FindNumber(int number, int[]Array){
    for(int i=0; i <Array.Length; i++){
        if(Array[i]==number)
        return Array[i];
    }
return false;
}*/




//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].int[] GetArray(int size){
    

int[] Array = GetArray(123);
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
}