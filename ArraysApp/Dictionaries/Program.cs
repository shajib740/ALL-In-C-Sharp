

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup.Add("animal", "Not a human");
lookup.Add("fish", "Not a human that swims");

lookup["human"] = "This is us";
Console.WriteLine($"Defition of fish is {lookup["human"]}");

Dictionary<int, string> employee = new Dictionary<int, string>();

employee[95] = "Shajib Chowdhury";
employee[28] = "Tim Corey";

Console.WriteLine($"The employee with ID number 95 is {employee[95]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Monday"] = 5;
dayOfWeek["Saturday"] = 1;
dayOfWeek["Monday"] = 4;


Console.WriteLine("Monday is day number: " + dayOfWeek["Monday"]);