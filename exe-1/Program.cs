// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponenta(int A, int B)
{
    int result = 1;

    for(int i = 1; i<=B; i++)
    {
        result *= A;
    }

    return result;
}

Console.Write("Введите число A: ");
var numberString = Console.ReadLine();
int A = int.Parse(numberString!);

Console.Write("Введите число B: ");
var numberString2 = Console.ReadLine();
int B = int.Parse(numberString2!);

int exponenta = Exponenta(A, B);
Console.WriteLine("Ответ: " + exponenta);

