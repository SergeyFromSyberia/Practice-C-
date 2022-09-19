// Задача 2: 
// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число");
int x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите второе число");
int z = Convert.ToInt32 (Console.ReadLine());
int max = 0;
if (x>z) 
{
    max= x;
    Console.WriteLine($"Число1 - {x} больше, число {z} меньше");
}
else if (x==z) 
{
    Console.WriteLine($"Числа равны");
}    
else Console.WriteLine($"Число - {z} больше, число {x} меньше");
