Console.Clear();
//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] arr = getArray();
checkArray(arr);
printArray(arr);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 findCrossPoint();
//-------------------------------------------------------------


void printArray(int[] array) //печать массива
{
    System.Console.WriteLine("получи: " + string.Join(", ", array));
}

int[] getArray() //принимает значение из консоли и лепит из этого массив чисел
{
    System.Console.WriteLine("введи числа массива через пробел: ");
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void checkArray(int[] array) //считает сколько элементов больше нуля
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 1)
            count++;
    }
    System.Console.WriteLine("количество больше нуля: " + count);

}
void findCrossPoint()
{
    Console.WriteLine("введи b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введи k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введи b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введи k2");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine("точка пресечения по Х:" + x + " Y: " + y);

}