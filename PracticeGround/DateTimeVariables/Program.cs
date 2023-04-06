

using System.Globalization;

DateTime today = DateTime.UtcNow;

//DateTime birthDay = DateTime.Parse("5/6/1993");

 //DateTime birthDay = DateTime.ParseExact("1/jun/1993", "d/MMM/yyyy", CultureInfo.InvariantCulture);
//Console.WriteLine(birthDay.ToString("F"));


Console.WriteLine(today.ToString("MMMM dd yyyy hh:mm tt zzz"));