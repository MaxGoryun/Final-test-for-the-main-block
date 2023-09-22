Console.WriteLine("Введите длину массива: ");
int LenArr = Convert.ToInt32(Console.ReadLine());

string[] MyArray = new string[LenArr];

for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    MyArray[i] = Console.ReadLine()!;
}

for (int j = 0; j < MyArray.GetLength(0); j++)
{
    Console.Write(MyArray[j] + ", ");
}
System.Console.WriteLine();
//int round = new Random().Next(0, 4);
string[] newArray = new string[new Random().Next(0, 4)];

for (int y = 0; y < newArray.Length; y++)
{
    int x = new Random().Next(0, LenArr - 1);
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (newArray[y] == MyArray[i])
        {
            continue;
        }
    }
    newArray[y] = MyArray[x];
    Console.Write(newArray[y] + ", ");
} 

