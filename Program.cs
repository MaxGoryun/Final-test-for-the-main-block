
string[] MyArray = {"Рано", "утром",  "дед", "с", "внуком", "отправились", "на", "рыбалку.", "Взяли", "с", "собой", "удочек,", "ведёрко", "да", "червей", "наловили.", 
"Сели", "в", "тени", "деревьев", "и", "закинули", "удочки.", "Красные", "поплавки", "весело", "прыгали", "в", "прозрачной", "воде.", "Славный", "вышел", "улов!"};

System.Console.WriteLine("Начальный массив: ");
for (int j = 0; j < MyArray.GetLength(0); j++)
{
    Console.Write(MyArray[j] + ", ");
}

System.Console.WriteLine();

string x = "";
System.Console.WriteLine("Резуьтат:  ");
for (int i = 0; i < MyArray.Length; i++)
{
    if (MyArray[i].Length <= 3)
    {
        x = x + MyArray[i]+ ", ";
    }
}
Console.WriteLine(x);

