//Console.Write("Введите первое число:");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите второе число:");
//int number2 = Convert.ToInt32(Console.ReadLine());
//if (number1 > number2)
//{
//    Console.WriteLine("Первое - большее,второе - меньшее");
//}
//else 
//{
//   Console.WriteLine("Второе - большее,первое - меньшее"); 
//}

Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число:");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ( number1 > number2)
{ 
    max = number1;
}
else 
{ 
    max = number2;
}
if ( number3 > max)
{ 
    max = number3;
}
Console.WriteLine(max);