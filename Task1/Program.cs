//  Написать программу, которая из имеющегося массива строк формирует новый массив 
//  из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать 
//  на старте выполнения алгоритма. При решении не рекомендуется 
//  пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("      " + "Здравствуйте! Я формирую новый массив из того, что есть.");
Console.WriteLine();
string[] array = new string[4];
string[] newarray = new string[array.Length];
SecondArray(array, newarray);
PrintArray(newarray);

void SecondArray(string[] array, string[] newarray)
{
    Console.WriteLine("Введите элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("array[{0}] = ", i);
        array[i] = Console.ReadLine();
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] newarray)
{
    for (int i = 0; i < newarray.Length; i++)
    {
        Console.Write($"{newarray[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
