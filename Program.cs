
string [] CreateArrayString()
{
    Console.Write($"Введите количество строк: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string[] arraystring1 = new string[number];
    for (int i = 0; i < number; i++) 
    {
        Console.WriteLine("Введите строку: ");
        string stringZero = Console.ReadLine();
        arraystring1[i] = stringZero;
    } 
    return arraystring1;
}

string[] arraystring = CreateArrayString();
string[] NewArraystring = new string[arraystring.Length];
int j=0;
 

Console.WriteLine($"Новый массив:");
for (int i = 0; i < NewArraystring.Length; i++) 
{ 
    if (arraystring[i].Length<4)
    {
        NewArraystring[j] = arraystring[i];
        Console.WriteLine($"   {NewArraystring[j]}");
        j+=1;
    }
} 

