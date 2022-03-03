//here is what NOT to do!!!
object[] stuff = new object[5];
stuff[0]="Terry";
stuff[1]=1;
stuff[2]=44.75;
stuff[3]="Buffalo Bill";

//WE NEED TYPE SAFETY!!!!
//Array
//this is a collection of 'char' or characters
string stringExample ="Hello World";

//Array of type string
string[] stringArray = 
{
    "Hello",
    "World",
    "Why",
    "is it",
    "Always",
    stringExample,
    "?"
};

string thirdItem = stringArray[3]; // 'is it' is the output
System.Console.WriteLine(thirdItem);

//change the value of the first item in the stringArray[]
stringArray[0] = "Hey there.";
System.Console.WriteLine(stringArray[0]);

//Lists<T>
// can only be used with System.Collections.Generic (using statement)
List<string> listOfStrings = new List<string>();
List<int> listOfIntegers = new List<int>();

listOfStrings.Add("First sting of our list.");
listOfIntegers.Add(46210);

System.Console.WriteLine(listOfIntegers[0]);

//--Queues
//this is a line
//whoever is first in line is first to be serviced
Queue<string> firstInFirstOut = new Queue<string>();

//this is to add to the queue:
firstInFirstOut.Enqueue("I'm First");
firstInFirstOut.Enqueue("I'm Second");

//what we can do is 'see who is next in line'
string seeWhoIsNext = firstInFirstOut.Peek();
System.Console.WriteLine(seeWhoIsNext);


//removing an item
//we cannot remove just any item we want, we can only remove item first in queue
 string removedItem = firstInFirstOut.Dequeue();
 System.Console.WriteLine($"removed : {removedItem}");

 string whoIsNextInLine = firstInFirstOut.Peek();
 System.Console.WriteLine($"next: {whoIsNextInLine}");
 System.Console.WriteLine("Testing Testing");

 //Dictionaries <TKey, TValue>
 Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

 //add to the dictionary
 keyAndValue.Add(7,"Agent");

 string valueSeven = keyAndValue[7];
 System.Console.WriteLine(valueSeven); //Agent

 //--Other Collections
 SortedList<int,string> sortedKeyandValue = new SortedList<int, string>();
 HashSet<int> uniqueList = new HashSet<int>();
 Stack<string> lastInFirstOut = new Stack<string>();

 //---------------------------------------------------------------------------

//How to deal with random numbers
Random rng = new Random();

//int randomNumber = rng.Next();
//() value sets range, first number is inclusive and second number is exclusive
int randomNumber = rng.Next();
System.Console.WriteLine(randomNumber);