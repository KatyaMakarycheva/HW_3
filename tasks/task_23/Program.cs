// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int array = Convert.ToInt32(Console.ReadLine());

void CubeNumber(int[] array)
{
    int index = 0;
    int length = array.Length;

    while (index < length)
    {
        array[index] = Convert.ToInt32(Math.Pow(index, 3));
        index++;
    }
}

void PrintArray(int[] number)
{
    int count = number.Length;
    int index = 0;

    while (index < count)
    {
        Console.Write(number[index] + "");
        index++;
    }
}

int[] result = new int[array + 1];
CubeNumber(result);
PrintArray(result);