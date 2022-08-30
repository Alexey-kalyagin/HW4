// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = {354, 897, 568, 234} ;
int sum = 0;   

        for (int i =0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine(array[i] + " - Число чётное ");
                sum = sum + 1;
                
            }
            else
            {
                Console.WriteLine(array[i] + " - Число нечётное ");
            }    
            
        }
        Console.WriteLine("Количество чётных чисел - " + sum);