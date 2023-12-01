// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива
Random rand = new Random();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
for (int i=0;i<size;i++){
    array[i]=Math.Round(rand.Next(10)+rand.NextDouble(),3);
    Console.Write(array[i]+" ");
}
double max=array[0];
double min=array[0];
for (int i=0;i<size;i++){
    if (array[i]>max) max=array[i];
    if (array[i]<min) min=array[i];
}
Console.WriteLine("\n"+$"{max-min}");