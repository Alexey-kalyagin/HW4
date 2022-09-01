// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int [] array = {1, 2, 3, 4, 5};
int count = array.Length; 
int Произведение1 = 0;
int Произведение2 = 0;
int Произведение3 = 0;

void PrintArray (int[]array)
{
   int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} {' '}");
    }
}

for(int i=0; i<count; i++)
{   
    int B = count%2;
    if (B>0)
    {
        Произведение3 = array[2]*1; 
    }

    Произведение1 = array[0]*array[4];
    Произведение2 = array[1]*array[3];
}

PrintArray(array);
Console.WriteLine(" ");
Console.WriteLine(Произведение1);
Console.WriteLine(Произведение2);   
Console.WriteLine(Произведение3);