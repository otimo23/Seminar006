/*Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2*/

Console.WriteLine("Enter numbers: ");
string elem = Console.ReadLine();
int[] basearray = GetStrArray(elem);
Console.WriteLine($"Positive numbers - {GetCount(basearray)}");

int[] GetStrArray(string StringAr)
{
    string[] ar = StringAr.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[ar.Length];
    for (int i = 0; i < ar.Length; i++)
    {
        result[i] = int.Parse(ar[i]);
    }
    return result;
}

int GetCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
            count = count + 1;
    }
    return count;
}