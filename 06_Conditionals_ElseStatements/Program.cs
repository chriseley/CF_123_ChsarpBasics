//So when we make an If statement, what happens when conditions aren't met
//This is where we use the else keyword (default "if all else fails")

//Example w/o the else statement
bool isRaining = true;

//Check if the inverse if isRaining is true
if (!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass.");
}
//Check if isRaining is true
if(isRaining)
{
    System.Console.WriteLine("I guess I can't cut the grass.");
}

//Ex: (w/ else statement):
if(!isRaining)
{
    System.Console.WriteLine("I will go cut the grass.");
}
else{
    System.Console.WriteLine("I guess I can't go cut the grass.");
}

//Another Example
bool isGoingOutside =true;

if (isGoingOutside)
{
    System.Console.WriteLine("Make sure to dress for the weather!");
}
else if(isGoingOutside && isRaining)
{
    //code goes here, can list as many else if's as you want but if has to be first and else last.
}
else
{
    System.Console.WriteLine("Sounds like a sweats kind of day.");
}

//Challenge
//If..Else If Statements
//We are going to ask the user how they are doing on a scale of 1-5, with 5 being the best.
System.Console.WriteLine("How are you doing? (1-5)");

//this changes the 'string' value to an integer
string value = Console.ReadLine();
//We will run the nested if..else statements based on ther input with these responses:
if (value == "1")
{
    System.Console.WriteLine("Dang. We hope your day gets better!");
}
else if (value == 2)
{
    System.Console.WriteLine("Oh. Sorry to hear that.");
}
else if (value == 3)
{
    System.Console.WriteLine("Hope things improve!");
}
else if (value == 4)
{
    System.Console.WriteLine("Good stuff!");
}
else (value == 5);
{
    System.Console.WriteLine("That's great to hear!");
}

//1. Dang. We hope your day gets better!
//2. Oh. Sorry to hear that.
//3. Hope things improve!
//4. Good stuff!
//5. That's great to hear!