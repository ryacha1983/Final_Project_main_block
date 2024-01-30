
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

string [] RemoveStringNull(string[] tempArray, int k)
{
    string[] NewArray = new string[k];
   for (int i= 0; i < k; i++) 
{ 
   NewArray[i]=tempArray[i];
} 
    return NewArray;
}

string[] arraystring = CreateArrayString();
string[] TempArray = new string[arraystring.Length];
int j=0;
Console.WriteLine($"Новый массив:");

for (int i = 0; i < TempArray.Length; i++) 
{ 
    if (arraystring[i].Length<4)
    {
        TempArray[j] = arraystring[i];
        j+=1;
    }
} 

string[] NewArraystring = new string[j];
NewArraystring = RemoveStringNull(TempArray, j);
 Console.WriteLine($"[ {string.Join("; ",NewArraystring)}]");
  