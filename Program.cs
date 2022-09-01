//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число A -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B -> ");
int b = int.Parse(Console.ReadLine());
int exp=1;

while (b<0)
{
    Console.Write("Число B не может быть отрицательным. Попробуйте снова -> ");
     b = int.Parse(Console.ReadLine());
} 

Console.Write ("Число "+a+", возведенное в степень "+b+ " -> ");

for(int i=1; i<=b; i++)
{
    exp = a*exp;
}
Console.WriteLine(exp); 

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число -> ");
int c = int.Parse(Console.ReadLine());
int summ = 0;

while (c!=0)
{
    summ=summ+c%10;
    c=c/10;
}

Console.WriteLine("Если сложить цифры, получится "+summ);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
//я сделала программу с возмолжностью задавать количество элементов массива самостоятельно


 int[] FillArray( int i) //принимает на вход количество элементов в массиве, возвращает заполненный массив

{   int[] array = new int[i]; 

    for(int count=0; count<i; count++)
    {
        array[count]= new Random().Next(1, 100);
    }
    return array;
}
void PrintArray(int[] massivePrint)
{
    for(int count=0; count<massivePrint.Length; count++)
    {
        Console.Write(massivePrint[count]+" ");
    }
}

Console.Write("Введите размер массива -> ");
int razmer = int.Parse(Console.ReadLine());


PrintArray(FillArray(razmer));
