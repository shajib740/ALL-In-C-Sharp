

TimeOnly opensAt = TimeOnly.Parse("8:0 AM");
TimeOnly endsAt = TimeOnly.Parse("10:0 PM");
TimeSpan newTime = endsAt - opensAt;
Console.WriteLine(newTime.ToString());

TimeOnly rightNow = TimeOnly.FromTimeSpan(newTime);
Console.WriteLine(rightNow);