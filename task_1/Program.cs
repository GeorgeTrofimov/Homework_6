//  Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов: ");

int element=int.Parse(Console.ReadLine());

int [] MyArr = new int [element];
for (int i = 0; i < MyArr.Length; i++)
{
    Console.Write($"Введите элемент массива №{i} : ");
    MyArr[i]=int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"Числа массива: ");

for (int i = 0; i < MyArr.Length; i++)
{
    System.Console.WriteLine(MyArr[i]);
}

System.Console.WriteLine($"Количество положительных чисел равен : ");

int count=0;
for (int i = 0; i < MyArr.Length; i++)
{
    if (MyArr[i]>0)
    {
        count++;
    }
}
System.Console.WriteLine(count);