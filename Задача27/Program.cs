//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число A");
string A = Console.ReadLine();
int sum = 0;
for (int i = 0; i < A.Length;i++)
{
    sum = sum + Convert.ToInt32(A[i].ToString());
}

Console.WriteLine(sum);

