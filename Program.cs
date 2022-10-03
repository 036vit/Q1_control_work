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

Console.WriteLine("Новый массив: ");
Console.WriteLine(String.Join("; ", array));