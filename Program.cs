// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       if(i<array.Length-1)Console.Write($"{array[i]}, ");
       else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] GetSummMax(int[] array)
{
double Max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>Max) Max = array[i]; 
}
return new double[] {Max};
}



double[] arr = CreateArrayRndInt(12, -20, 20);

PrintArray(arr);

double[] PosMax = GetSummMax(arr);
Console.WriteLine ($"Максимальное число: {PosMax [0]}");
//Console.WriteLine ($"Минимальное число: {sumPosMin [1]}");
