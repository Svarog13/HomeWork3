Console.WriteLine("Enter four digit: ");

int result = 0;
for (int i = 0; i < 4; i++)
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out int digit) && input.Length == 1)
    {
        result = result * 10 + digit;
    }
    else
    {
        Console.WriteLine("Wrong enter. Please, ente one digit.");
        i--;
    }
}

Console.WriteLine($"We have digit: {result}");