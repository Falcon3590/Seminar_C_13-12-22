//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] array = new double[10];

for(int i = 0; i < 10; i++){

    Random rnd = new Random(); 

    array[i] = rnd.Next(99, 9999);
}

double MaxNumber = array[0];

double MinNumber = array[0];

for(int i = 1; i < 10; i++){
    
    if(array[i] > MaxNumber)
    {
        MaxNumber = array[i];
    }   
    
    if(array[i] < MinNumber)
    {
        MinNumber = array[i];
    }   
    
}

Console.Write("[");

for (int i = 0; i < array.Length - 1; i++)
{
    Console.Write($"{array[i]}, \t");
}
Console.Write($"{array[9]}]\n");

Console.Write($"Разниа между максимальным {MaxNumber} и минимальным {MinNumber} элементов массива = {MaxNumber - MinNumber}");



