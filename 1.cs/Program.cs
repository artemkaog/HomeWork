﻿// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [20,90].
Random rand= new Random();
int size=10;
int[] array = new int[size];
for (int i = 0; i<size;i++){
    array[i]=rand.Next(1,101);
    Console.Write(array[i]+" ");
}
int k=0;
for (int i=0;i<size;i++){
    if (array[i]>=20 && array[i]<=90) k+=1;
}
Console.WriteLine("\n"+k);