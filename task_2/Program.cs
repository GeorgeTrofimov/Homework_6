//  Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write (message);
    double a = double.Parse(Console.ReadLine());
    return a;
}

double b1 = Prompt ("Введите значение b1: ");
double k1 = Prompt ("Введите значение k1: ");
double b2 = Prompt ("Введите значение b2: ");
double k2 = Prompt ("Введите значение k2: ");



    double x=-(b2-b1)/(k2-k1);
    double y1=k1*x+b1;
    
    System.Console.WriteLine($"Точка пересечения ({x}; {y1})");

