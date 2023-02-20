// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using static System.Console;

WriteLine("Введите массив через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine();
Console.WriteLine("{0}", string.Join(", ", SelectArray(array)));


string[] SelectArray(string[] inArray)
{
    string[] resultArray = new string[ArraySize(inArray)];
    int count = 0;
    foreach (var item in inArray)
    {
        if (item.Length <= 3)
        {
            resultArray[count] = item;
            count++;
        }
    }
    return resultArray;

}


int ArraySize(string[] inArray) 
{
    int result = 0;
    foreach (var item in inArray)
    {
        if (item.Length <= 3)
            result++;
    }
    return result;
}


