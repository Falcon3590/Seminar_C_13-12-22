//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] array = new double[10];

for(int i = 0; i < 10; i++){

    Random rnd = new Random(); 

    array[i] = rnd.Next(99, 9999);
}

double Maximum = array[0];

double Minimum = array[0];

for(int i = 1; i < 10; i++){
    
    if(array[i] > Maximum)
    {
        Maximum = array[i];
    }   
    
    if(array[i] < Minimum)
    {
        Minimum = array[i];
    }   
    
}

Console.Write("[");

for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, \t");
}
Console.Write($"{array[9]}]\n");

Console.Write($"Разниа между максимальным {Maximum} и минимальным {Minimum} элементов массива = {Maximum - Minimum}");



