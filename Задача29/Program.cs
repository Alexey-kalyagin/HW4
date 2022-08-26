 // Напишите программу, которая задаёт массив из N элементов и выводит их на экран.




    int [] array = new int [5];
    array [0] = 1;
    array [1] = 2;
    array [2] = 5;
    array [3] = 7;
    array [4] = 19;

static void WrireArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}     

    WrireArray(array);


