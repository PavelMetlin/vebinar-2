//задача 1
int num = new Random().Next(100, 1000); 
System.Console.WriteLine(num);
int dig1 = num / 10; 
int dig2 = dig1 % 10;
Console.WriteLine(dig2);
