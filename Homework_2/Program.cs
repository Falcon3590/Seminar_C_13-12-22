// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int[10];
int sum = 0;

for (int i = 0; i <= 9; i++)

{

Random rnd = new Random(); 
    
int N = rnd.Next(10, 9999); 
    
array[i] = N;
Console.WriteLine($"элементы {i%2!}");
Console.WriteLine($"номер {N}");  
    
    if (i%2!=0)
    {
        sum += array[i]; 
    }
                       
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
