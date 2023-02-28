//Написать программу, которая из имеющегося массива строк формирует массив,
// состоящий только из тех строк, что меньше или равны 3 символам
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

string[] GenerateArrayString(int size)
{
    string[] array = new string[size];
    return array;
}
void FillAndPrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Type in values for index {i}");
       array[i] = Convert.ToString(Console.ReadLine()) ;
    }
        Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int HowManyElements(string[] array)
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<4 && array[i].Length>=0) count++;
        Console.WriteLine($"count is {count}");
    }
    return count;
}
Console.WriteLine("Type in size for your string array");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] arrayString = GenerateArrayString(arraySize);
FillAndPrintArray(arrayString);
int wordCount = HowManyElements(arrayString);
