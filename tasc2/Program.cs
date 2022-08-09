//задача 2
int Num = new Random().Next(10, 1000);
System.Console.WriteLine(Num);
string NumText = Convert.ToString(Num);
if (NumText.Length > 2)
{
    Console.WriteLine("третья цифра -> " + NumText[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}