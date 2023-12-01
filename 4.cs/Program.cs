// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м 
// индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.
Console.WriteLine("Введите натуральное число в диапазоне от 1 до 100 000");
int num = Convert.ToInt32(Console.ReadLine());
int num1=num;
int size=0;
while (num!=0){
    num=num/10;
    size++;
}
int[] array= new int[size];
for (int i =0;i<size;i++){
    array[size-i-1]=num1%10;
    num1=num1/10;
}
for (int i =0;i<size;i++){
    Console.Write(array[i]+" ");
}