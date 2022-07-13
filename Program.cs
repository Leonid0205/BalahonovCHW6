// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

int[] CreateArray(int m)
{
    int[] array = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write("Input a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int ShowPositiveNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}
Console.Write("How many numbers do you want to input: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(m);
ShowArray(array);
Console.WriteLine("The quantity of positive numbers is: " + ShowPositiveNumbers(array));
Console.WriteLine();

//  Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
//b1, k1, b2 и k2 задаются пользователем.

void PointOfIntersection(double b1, double k1, double b2, double k2)
{
    double y;
    double x;
    x = (b2 - b1)/(k1 - k2);
    y = x * k2 + b2;
    Console.Write($"The point of intersrction is: ({x}, {y})");
}
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
PointOfIntersection(b1, k1, b2, k2);