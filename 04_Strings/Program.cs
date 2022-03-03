//Strings

//Just a collection of characters stored and used throughout an application in different ways
//Almost any text, single character, or number can be a string

//In C# we can initialize string by using double quotes ("") wrapped around the value

//3 ways to use a string type
//Concatenation
//Composite Formating
//Interpolation

//Concatenation Ex:
string first = "The cars we sell are";
string second = "BMW, Mercedes, and VW";

string concatenatedResult = first + " " + second;
//basically taking the variables and (+) them one to another, we also added the " " as well.
System.Console.WriteLine(concatenatedResult);

//Composite Formatting
//using {} braces inside of the string itself with a number inside of the braces
string firstName = "Chad";
string lastName = "Bradford";

//now we need to use string.Format method
string compositeResult = string.Format("His name is {0} {1}",firstName,lastName);
System.Console.WriteLine(compositeResult);

//String Internalation
//Allows you to simply put a variable directly into the string.
string interpolationResult = $"His name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);

//Challenge
//Practice these three ways of joining strings (3) more examples of each

//Conccantenation
String one = "My name is Charlie";
String two = "and I am a dog";

string concatenatedResult2 = one + ", " + two;
System.Console.WriteLine(concatenatedResult2);

//Composite Formatting
string dogName = "Charlie";
string dogBreed = "Mutt";
string compositeResult2 = string.Format("The dog's name and breed are {0} and {1}", dogName,dogBreed);
System.Console.WriteLine(compositeResult2);