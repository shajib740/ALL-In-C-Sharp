

using System.Text;

string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Shajib";
lastName = "Chowdhury";
//filePath = "C:\\Temp\\Demo \n";
filePath = " \"C:\\Temp\\Demo \n";


string testString = @$" 'The file for {firstName} is ""at {filePath} ";

Console.Write(testString);
Console.Write(filePath);
// " " is string lietaral;
Console.WriteLine(firstName + " " + lastName); 
// String interpolation
Console.WriteLine($"{firstName} {lastName} ");


