// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[] FillArray(int[] a) //Заполняем массив
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0, 8);
    }
    return a;
}
void PrintArray(int[] a) //Печатаем массив
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write($"{a[i]} ");
    }
}
int N = Prompt("Введите длиину массива: ");
int[] a = new int[N];
PrintArray(FillArray(a)); //Вызываем функцию заполнения массива внутри функции печати