﻿//Написать программу, которая из имеющегося массива строк формирует массив,
// состоящий только из тех строк, что меньше или равны 3 символам
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

string[] GenerateArrayString(int size)
{
    string[] array = new string[size];
    return array;
}

Console.WriteLine("Type in size for your string array");
int arraySize = Convert.ToInt32(Console.ReadLine());
string[] arrayString = GenerateArrayString(arraySize);

