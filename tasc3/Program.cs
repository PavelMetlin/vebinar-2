// задача 3
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("(этот день выходной) -> да");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("это не день недели");
    }
    else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNum);