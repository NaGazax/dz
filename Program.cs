Console.Write("Введите число:");
string firstNumber = Console.ReadLine();  
int secondNumber = Convert.ToInt32(firstNumber);
if (secondNumber < 100) 
{
    Console.WriteLine("Неверное число");
}      
Console.WriteLine(firstNumber[2]);
    