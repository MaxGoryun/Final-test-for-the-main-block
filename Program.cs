
string[] MyArray = {"Рано" , "утром" ,  "дед" , "с" , "внуком" , "отправились", "на", "рыбалку.", "Взяли", "с", "собой", "удочек,", "ведёрко", "да", "червей", "наловили.", 
"Сели", "в", "тени", "деревьев", "и", "закинули", "удочки.", "Красные", "поплавки", "весело", "прыгали", "в", "прозрачной", "воде.", "Славный", "вышел", "улов!"};

System.Console.WriteLine("Начальный массив: ");
for (int j = 0; j < MyArray.GetLength(0); j++)
{
    Console.Write(MyArray[j] + ", ");
}

System.Console.WriteLine();

int count = 0;
string z = "";

for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i].Length <= 3 && MyArray[i] != ",")
    {
        z = z + MyArray[i] + " ";
        count++;
    }
}

System.Console.WriteLine("Результат:  ");
string[] Answer = z.Split(',');

Console.WriteLine(String.Join(",", Answer));

