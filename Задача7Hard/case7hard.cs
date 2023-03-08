//Задача 7 HARD по желанию - идет за 2 необязательных 
//Напишите программу, которая принимает на вход целое число любой разрядности 
//и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. 
//
//Через строку решать нельзя.
//
//456111 -> 5; 78 -> 8; 9146548 -> 1; 3 -> нет
//
Console.WriteLine("Введите целое число: ");
long num = Convert.ToInt64(Console.ReadLine()); 
num = Math.Abs(num); //модуль числа num
if(num>100)
{
while(num>100)
    num/=10;
Console.Write(Convert.ToUInt16(num%10));
}
else if(num>10)
    Console.Write(Convert.ToUInt16(num%10));
else
Console.WriteLine("нет!!!");