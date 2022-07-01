Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if ( dayNumber >= 1 && dayNumber <= 7 );
{
    if (dayNumber >= 6 && dayNumber <= 7)
    {
       Console.WriteLine("Выходной"); 
    }
    else 
    { 
       Console.WriteLine("Будни"); 
    }
}
