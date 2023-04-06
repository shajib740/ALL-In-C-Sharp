



string data = "C#,Python,Java,Javascript";
List<string> programmingList = data.Split (',').ToList();


for (int i = 0; i < programmingList.Count; i++)
{
    Console.WriteLine($" Programming language {programmingList[i]} is in the list");
}

List<decimal> charges = new();

charges.Add(12.3M);
charges.Add(1.4M);
charges.Add(10.3443M);
charges.Add(12.3M);

Decimal total = 0M;

for (int i = 0; i < charges.Count; i++)
{
    total += charges[i];    
}

Console.WriteLine($"Total charge is: {total}");
