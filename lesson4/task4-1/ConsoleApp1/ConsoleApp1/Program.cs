


// task 4 - 1------------------------------------------------------------------

// weekday variables----
var day1 = "Monday";
var day2 = "Tuesday";
var day3 = "Wednesday";
var day4 = "Thursday";
var day5 = "Friday";
var day6 = "Saturday";
var day7 = "Sunday";
//---------------------

// it's a loop label
Start:
//-----------------

// displays a helpful hint on the screen----------
Console.WriteLine("Enter the day number: (1-7)");
//-----------------------------------------------

// there's a user input---------------
string userInput = Console.ReadLine();
//------------------------------------

// trying to turn user input into a number--------------------
bool isNumber = byte.TryParse(userInput, out byte dayNumbers);
//------------------------------------------------------------

// checking conditions for outputting days of the week-------------------------
if (isNumber)
{
    if (dayNumbers == 1) Console.WriteLine("You've chosen " + day1 + "!");
    else if (dayNumbers == 2) Console.WriteLine("You've chosen " + day2 + "!");
    else if (dayNumbers == 3) Console.WriteLine("You've chosen " + day3 + "!");
    else if (dayNumbers == 4) Console.WriteLine("You've chosen " + day4 + "!");
    else if (dayNumbers == 5) Console.WriteLine("You've chosen " + day5 + "!");
    else if (dayNumbers == 6) Console.WriteLine("You've chosen " + day6 + "!");
    else if (dayNumbers == 7) Console.WriteLine("You've chosen " + day7 + "!");
    else Console.WriteLine("Incorrect number!");
}
else
{
    Console.WriteLine("It's not a number: " + userInput);
}
//-----------------------------------------------------------------------------

// go to the selected label to loop
goto Start;
//---------------------------------

