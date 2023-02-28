/*Задача 39:** Напишите программу,
 которая перевернёт одномерный массив 
 (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/
int[] startarray = GetRandomArray(7, 1, 10);
Console.WriteLine(string.Join(", ", startarray));
startarray = ReversMass (startarray);
Console.Write  (startarray);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int [] ReversMass (int[] array)
{
int[]ar = new int[array.Length];
int j = 0;
for(int i = array.Length; i >=0; i--)
{
    ar[j] = array[i];
    j++;
}
return ar;
}
