


//string[] firstNames = new string[5];

//firstNames[0] = "Shajib";
//firstNames[1] = "Tommy";
//firstNames[2] = "Mummy";
//firstNames[3] = "Jimmy";
//firstNames[4] = "Dommy";

//Console.WriteLine($"The firstNames are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[3]}, {firstNames[4]}");

string data = @"Shajib,Tommy,,asd,Mummy,Jimmy,Dommy ";
// Single quote identifies a char
// Double quote identifies a string
string[] firstNames = data.Split(',','"');

foreach (string name in firstNames)
{
    Console.WriteLine(name);
}

//while ()
//{
    
//} 

string [] lastNames = new string[] { "Chowdhury","Ghosh",};