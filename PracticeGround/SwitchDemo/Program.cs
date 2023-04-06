



string firstName = "ROBSON";
int age = 31;

switch (firstName.ToLower())
{
    case "robson":
        Console.WriteLine($"Hello {firstName} Chowdhury");
        break;

    default:
        Console.WriteLine("No name matches");
        break;
}

switch (age)
{
    case >= 20 and < 30:
        Console.WriteLine("You are in your 20's");
        break;
    default:
        Console.WriteLine("Age was not in an expected range");
        break;
}