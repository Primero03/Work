int P3()
{
    Console.WriteLine("Ваше число");
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (isParsed)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введенные символы,не являются верными в данном контексте");
        return num = int.Parse(Console.ReadLine());
    }
}

int arrayLength3 = P3();

string[] array = new string[arrayLength3];

System.Console.WriteLine("Какие будут слова в массиве?:");
for (int i = 0; i < arrayLength3; i++)
{
    System.Console.Write($"{i + 1} выражение: ");
    array[i] = Console.ReadLine();
}
System.Console.WriteLine('[' + string.Join(",", array) + ']');

int temporaryLengt = 0;
for (int i = 0; i < arrayLength3; i++)
{
    if (array[i].Length <= 3 && array[i].Length > 0)
    {
        temporaryLengt++;
    }

}

string[] temporary = new string[temporaryLengt];
int j = 0;
for (int i = 0; i < arrayLength3; i++)
{
    if (array[i].Length <= 3 && array[i].Length > 0)
    {
        temporary[j] = array[i];
        j++;
    }
}
System.Console.Write("New array:");
System.Console.WriteLine('[' + string.Join(",", temporary) + ']');