Console.Clear();
Console.Write("Введите число ");
int namber=Convert.ToInt32(Console.ReadLine());
int count=0;
while(namber!=0)
{
    count=count+namber%10;
    namber=namber/10;
}
Console.Write(count);

