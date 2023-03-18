Console.Clear();
Console.Write("Введите число 1 ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int number2=Convert.ToInt32(Console.ReadLine());
int square=number1;
for (int index=2;index<=number2;index++)
{
    square=square*number1;
}
Console.WriteLine(square);