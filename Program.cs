Console.Write($"Введите количество строк: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели:   {number}");
string[] arraystring = new string[number];




 for (int i = 0; i < number; i++) 
{
    Console.WriteLine("Введите строку: ");
    string stringZero = Console.ReadLine();
    // Console.WriteLine($"Вы ввели строку:   {stringZero}");
    arraystring[i] = stringZero;
} 
Console.WriteLine($"Новый массив:");
for (int i = 0; i < number; i++) 
{ 
    if (arraystring[i].Length <4)
        Console.WriteLine($"   {arraystring[i]}");
} 
