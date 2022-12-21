Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int secondnumber = number / 10 % 10;

Console.WriteLine($"{secondnumber}");
