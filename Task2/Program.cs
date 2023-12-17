// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] randArray = new int[size];

int[] FillArrayRandomNumbers(int[] randArray)
{
    Random rand = new Random();
    for(int i = 0; i < randArray.Length; i++)
    {
        randArray[i] = rand.Next(100,1000);
    }
    return randArray;
}

void PrintArray(int[] randArray)
{
    Console.Write("[" + string.Join(" ", randArray) + "]");
    Console.WriteLine();
}

int countEven(int[] randArray)
{
    int count = 0;
    for (int i = 0; i < randArray.Length; i++)
    {
        if (randArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

FillArrayRandomNumbers(randArray);
Console.WriteLine("Массив: ");
PrintArray(randArray);
Console.WriteLine($"Чётных чисел в массиве - {countEven(randArray)}");