// 4.12, 32, 1.234

// Decimal is more precise than Double. Decimal has 28 digit precision. Wherever double has 16 digit precision
// We don't always use Decimal instead of Double to use memory  efficiently
// Decimal use more memory as it needs more space
decimal bankAccountBalance;
double averagaAge;
averagaAge = (1.0 / 3);

//bankAccountBalance = 2.5; // can't use this
bankAccountBalance = 2.5M; // have to specifically metion that this is a decimal by using 'M' at the end
bankAccountBalance = (1.0M / 3);
Console.WriteLine(averagaAge);
Console.WriteLine(bankAccountBalance);


