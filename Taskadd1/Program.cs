Console.Clear();

void shiftArr(int[] col) //Сдвиг массива на 1 позицию
{
    int buffer = col[0];
    for (int i = 0; i < col.Length - 1; i++)
    {
        col[i] = col[i + 1];
    }
    col[col.Length - 1] = buffer;
}
void shifArrPos(int[]col,int shift) //Сдвиг массима на N позиций
{
    for(int i=0;i<shift;i++)
{
    shiftArr(col);
}
}
// int arrAdd(int count)// Создание массива из count чисел от 1 до 100
// {
//     int[] arr = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         arr[i] = new Random().Next(1, 101);
//     }
//     return arr;

// }

Console.Write("Введите размер массива ");
int count=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сдвиг ");
int shift=Convert.ToInt32(Console.ReadLine());

//int count=10;
int[]arr=new int[count];
for (int i = 0; i <arr.Length; i++)
{
    arr[i] = new Random().Next(1, 101);
}
// int []arr = arrAdd(10);
Console.WriteLine($"[{String.Join(",",arr)}]");
shifArrPos(arr,shift);
Console.WriteLine($"[{String.Join(",",arr)}]");
