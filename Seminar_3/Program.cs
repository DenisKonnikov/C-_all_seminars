// Способ решения задачи 2 (семинара 2) Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Берем числа до 100000

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*System.Console.WriteLine("Введите число:");
string number = Console.ReadLine();
if (number.Length < 3)
{
    System.Console.WriteLine("Ошибка");
}
else
{
    System.Console.WriteLine(number[2]);
}

System.Console.WriteLine(Convert.ToInt32(Convert.ToString(number[2]))+10); // Конвертация  char переменной (number[2]) 
//через string (строки) в int (число) через две конвертации.*/


//Задача1. Написать прорамму, которая принимает на вход координаты точки (Y,X), причем Х/= и Y=/0 и выдает четверти плоскости в которой она находится. 

/*System.Console.WriteLine("Введите переменную Х");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите переменную Y");
int y = Convert.ToInt32(System.Console.ReadLine());

// Convert.ToInt32 внутри себя обращается к Int.Parse внутри себя. То есть разницы практически никакой. 

if (x == 0 || y == 0)
{
    System.Console.WriteLine("X и Y не должны равняться 0");
}

else if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка расположениа в первой четверти");
}
else if (x > 0 && y < 0) 
{
    System.Console.WriteLine("Точка расположениа в четвертой четверти");
}
else if (x < 0 && y > 0) 
{
    System.Console.WriteLine("Точка расположениа во второй четверти");
}
else if (x < 0 && y < 0) 
{
    System.Console.WriteLine("Точка расположениа в третьей четверти");
}*/

// Задача2: напишите программу, которая по заданному номеру етверти, показывает диапазон возможных координатточек в той четверти(Х,У)

/*System.Console.WriteLine("Введите номер четверти");
int number = Convert.ToInt32(System.Console.ReadLine());


if (number == 1)
{
    System.Console.WriteLine("Диаппазон первой четверти {x>0} и {y>0}");
}
else if (number == 2)
{
    System.Console.WriteLine("Диаппазон второй четверти {x<0} и {y>0}");
}
else if (number == 3)
{
    System.Console.WriteLine("Диаппазон третьей четверти {x<0} и {y<0}");
}
else if (number == 4)
{
    System.Console.WriteLine("Диаппазон четвертой четверти {x>0} и {y<0}");
}

else {
    System.Console.WriteLine("Такой четверти не существует");
}
*/

//Задача 3. Написать программу которая принимает координаты двух точек и находит координаты в 2Д пространстве.

//((x1-x2)^2+(y1-y2)^2)^(1/2)

/*System.Console.WriteLine("Ввести координату Х точки А:");
int x1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ввести координату У точки А:");
int y1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Ввести координаты Х точки Б:");
int x2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Ввести координаты У точки Б:");
int y2 = Convert.ToInt32(System.Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+ Math.Pow((y1-y2),2)),2); 
// Math.Pow - возведение в степень, Math.Sqrt - берет квадратный корень, Math.Round - округление числа 

System.Console.WriteLine($" Расстояние между двумя точками: {result}");*/

// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

/*System.Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

// for(int i=1; i<=x; i++){
// System.Console.WriteLine(Math.Pow(i, 2));
// }

int count = 1;
while (count <= x){
    System.Console.Write(Math.Pow(count, 2)+" ");
    count++;
}*/

// Задача: Выведите четные числа от 1 до 15. 

/*for (int i = 0; i <= 30; i=i+3)
{
    // if (i % 2 == 0)
    // {
        System.Console.Write(i + " ");
    }*/


// ПРОВЕРКА НА КОЛИЧЕСТВО СИМВОЛОВ 

// string text = System.Console.ReadLine();

// if (text.Length==5)


