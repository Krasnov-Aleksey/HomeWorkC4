Console.Clear();
int [] array=new int[8];
for (int index=0;index<8;index++)
{
    array[index]=new Random().Next(1,11);
}
Console.WriteLine($"{String.Join(" ",array)}");
