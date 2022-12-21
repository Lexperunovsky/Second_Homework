//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
//Вариант решения 1:

/*int DayOfWeek;
while(true)
{
Console.WriteLine("Введите число от 1 до 7: ");
    if (int.TryParse(Console.ReadLine(), out DayOfWeek))
        break;
        Console.WriteLine("Erorr!");
}
int weekdays = DayOfWeek;
int weekend = DayOfWeek;
if (weekdays <= 5)
{
    Console.WriteLine($"{weekdays} - день будний");
}
else 
    Console.WriteLine($"{weekend} - выходной день");*/


//Вариант решения 2:
Console.WriteLine("Введите число от 1 до 7, которое соответсвует дню недели: ");
int DayOfWeek = int.Parse(Console.ReadLine()??"");
int day = DayOfWeek;
if (day == 1) 
{
    Console.WriteLine("- понедельник, будний день");
}
else if (day == 2)
{
    Console.WriteLine("- вторник, будний день");
}
else if (day == 3)
{
    Console.WriteLine("- среда, будний день");
}
else if (day == 4)
{
    Console.WriteLine("- четверг, будний день");
}
else if (day == 5)
{
    Console.WriteLine("- пятница, будний день");
}
else if (day == 6)
{
    Console.WriteLine("- суббота, выходной день");
}
else if (day == 7)
{
    Console.WriteLine("- воскресенье, выходной день");
}
else 
Console.WriteLine($"Вы ввели неверное число");





