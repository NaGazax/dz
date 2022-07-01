int number = new Random().Next(100,1000);
Console.WriteLine("Рандомное число:" + number);
int digitOne = number / 100;
int digitThree = number % 10;
int digitTwo = (number - 100 * digitOne - digitThree) / 10;
Console.WriteLine($"Второе число: {digitTwo}");


