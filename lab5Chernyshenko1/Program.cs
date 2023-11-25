Console.WriteLine("Введите массив:");
char[] mas=Console.ReadLine().ToArray();
int max = 0;
int current = 0;
foreach (char c in mas)
{
    if (c =='a')
    {
        current++;
        if (current > max)
        {
            max = current;
        }
    }
    else 
    {
        current = 0;
    }
}
Console.WriteLine(max);