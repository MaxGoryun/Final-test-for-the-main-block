Console.WriteLine("Введите длину массива: ");
int LenArr = Convert.ToInt32(Console.ReadLine());

string[] MyArray = new string[LenArr];

for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}");
    MyArray[i] = Console.ReadLine()!;
}


for (int j = 0; j < MyArray.GetLength(0); j++)
{
    Console.Write(MyArray[j] + " , ");
}

