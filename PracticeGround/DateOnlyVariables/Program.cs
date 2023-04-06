

using System.Globalization;

DateTime today = DateTime.Parse("5/6/1993");
DateTime todayMod = DateTime.ParseExact("1/jun/1993", "d/MMM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"Today full format: {today.ToString("MMMM dd yy")}");
Console.WriteLine($"todayMod full format: {todayMod.ToString("MMMM dd yy")}");



DateOnly birthday = DateOnly.Parse("1/06/1993");
DateOnly birthdayMod = DateOnly.ParseExact("1/06/1993", "d/MM/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday.ToString("dd, MMMM,  yyyy"));

//Console.WriteLine("Today full format: "+ today);
//Console.WriteLine("Today just date: "+ today.Date.ToString("F"));
Console.WriteLine("birthdayMod: " + birthdayMod.ToString("MMMM dd yy"));