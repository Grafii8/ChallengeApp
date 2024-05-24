int number = 47420;
string NumberAsString = number.ToString();
char[] letters = NumberAsString.ToCharArray();

char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
Console.WriteLine("W liczbie " + NumberAsString + " ilosc zawartch cyfr wystepuje:");

foreach (char num in numbers)
{
    var counter = 0;
    foreach (char let in letters)
    {
        if (num == let)
        {
            counter++;
        }
    }
    Console.WriteLine(num + "-->" + counter);
}
