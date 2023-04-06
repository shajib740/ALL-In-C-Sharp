

string data = "Shajib,Tim,Sue,Jane";


List<string> firstNames =  data.Split(',').ToList();


foreach (string firstName in firstNames)
{
    Console.WriteLine($"User {firstName} is in the list");
}
