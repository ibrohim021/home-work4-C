// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] createArray()
{
    var random = new Random();
    var result = new int[8];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(0, 9);
    }
    return result;
}

var array = createArray();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ",");
}

Console.WriteLine();

