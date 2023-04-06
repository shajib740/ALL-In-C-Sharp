

// Converting to string from something else
Console.Write("Enter your age: ");
string ageText = Console.ReadLine();



int age;

bool isValidAge = int.TryParse(ageText, out  age);
Console.WriteLine($" This is valid? : {isValidAge}. The new age {age}" );

decimal testDecimal = decimal.Parse(ageText);
double testDouble = (double)testDecimal;


Console.WriteLine($" Double Equivalent Value: {testDouble}");
Console.WriteLine($" Decimal Equivalent Value: {testDecimal}");
