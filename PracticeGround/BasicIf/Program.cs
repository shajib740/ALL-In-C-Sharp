

//bool isComplete = false;

//if (isComplete)
//{
//    Console.WriteLine("The statement is true");
//}
//else 
//{ 
//    Console.WriteLine("The statement is true");
//}

Console.WriteLine("What is your first name: ");
string? firstName  = Console.ReadLine();
string lastName;

if (firstName.ToLower() == "shajib")
{
    Console.WriteLine("Hello Mr. Chowdhury");
    lastName = "";
}
else
{
    Console.WriteLine($"Hello {firstName}");
    lastName = ""; // if you don't set the lastName here it will show error. Because lastname does not have any initial value.
}
Console.WriteLine(lastName);