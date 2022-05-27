﻿/*
Задача 33: Задайте массив. Напишите программу,
 которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
System.Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

int[] arrayCreation(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for ( int i = 0 ; i< length ; i ++){
        arr[i] = rnd.Next(-9,10);
    }
return arr;}

string LookUp(int[] array,string lookUpNumber)
{
    string result = "Нет";
    int LookUpNumber = int.Parse(lookUpNumber);
    foreach (int item in array){
        if ( item == LookUpNumber) result = "Да";
    }
return result;
}

string PrintArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0) result = "[ " + Convert.ToString(array[i]) + ", ";//string builder
        else if (i < array.Length-1)
            result = result + Convert.ToString(array[i]) + ", ";
        else result = result + Convert.ToString(array[i]) + "]";
    }
return result;
}


Console.Write("Размер массива : ");
int length = int.Parse(Console.ReadLine());
int[] array = arrayCreation(length);
Console.Write("Что ищем ? : ");
string lookUp = Console.ReadLine();
Console.WriteLine($"{lookUp} ; {PrintArray(array)} - > {LookUp(array,lookUp)}");


