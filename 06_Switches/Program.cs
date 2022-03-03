//Has 3 parts:
// 'switch' keyword
// a value that is being evaluated
// 'case' keyword, indicate a new block of code to be executed if the value matches the given case.

//'break' keyword, which indicates the end of the case

//'default' keyword, which will run if "all else fails"

//Ex:
string name = Console.ReadLine();

//we are going to 'switch' on the value 'name'
switch (name)
{
    case "Pete":
    //Code that runs if name == "Pete"
    break;
    //so, if its anything other than Pete...
    default:
    //Code that runs if all else fails
    System.Console.WriteLine("Invalid Option!");
    break;
}

//real Example:
System.Console.WriteLine("How are you feeling today? (1-5)");
string feelingRating = Console.ReadLine();

switch(feelingRating)
{
    case "5":
    System.Console.WriteLine("That's great to hear!");
    break;

    case "4":
    System.Console.WriteLine("Good stuff!");
    break;

    case "3" :
    System.Console.WriteLine("Hope things improve!");
    break;

    case "2" :
    System.Console.WriteLine("Oh, sorry to hear that");
    break;

    case "1" :
    System.Console.WriteLine("Dang! Hope your day gets better!");
    break;

    default:
    System.Console.WriteLine("Sorry, we don't understand. Please try again.");
    break;
}

//Challenge 
//Creating a switch statement
//want to output discriptions for a few of your friends

//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
// what can you do with cases like "Paul" and "paul" as these are different values