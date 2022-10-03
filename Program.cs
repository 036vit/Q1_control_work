// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести в клавиаьуры, либо задать на старте выполнения алгоритма.

Console.Clear ();

Console.Write ("Введите символ или несколько:  ");
string? A = (Console.ReadLine());

Console.Write ("И ещё раз:  ");
string? B = (Console.ReadLine());

Console.Write ("Ещё раз:  ");
string? C = (Console.ReadLine());

Console.Write ("Последний раз:  ");
string? D = Console.ReadLine();

string [] array = new string [4] { A, B, C, D};

Console.WriteLine("");
Console.WriteLine("Основной массив: ");
Console.WriteLine(String.Join("; ", array));
Console.WriteLine("");
Console.WriteLine("Новый массив: ");

string[] array2 = new string[array.Length];
void SecondArrayWithIF(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array, array2);
PrintArray(array2);