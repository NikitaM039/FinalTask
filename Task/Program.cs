string[] array;
Console.WriteLine("Введите массив строк через пробел");
string? row = Console.ReadLine();
array = row.Split(' ');
string[] array2 = new string[array.Length];