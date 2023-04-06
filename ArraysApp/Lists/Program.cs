

List<string> firstName = new List<string>();

firstName.Add("shajib");
firstName.Add("Tim");
firstName.Add("Mim");

//Console.WriteLine($"{firstName[firstName.Count-1]}");

List<int> ages = new List<int>();

ages.Add(1);
ages.Add(2);

//List<T> - generic

string data = "Chowdhury,Corey,Ghosh";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");
lastNames.AddRange(firstName);
foreach (string name in lastNames)
{
    Console.WriteLine(name);
}
