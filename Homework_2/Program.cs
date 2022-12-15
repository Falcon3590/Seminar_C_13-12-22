// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[10];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    Random rnd = new Random(); 
  
    array[i] = rnd.Next(99, 9999);
}

for (int i = 0; i < array.Length; i+=2)
{   
    sum += array[i];
}
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, \t");
}
Console.Write($"]\n");

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");


