
// task 4-2--------------------------------------------------------------------

//user input and interface---------------------
Console.WriteLine();
Console.WriteLine("Enter your first number:");
string firstInput = Console.ReadLine();

Console.WriteLine("Enter your second number:");
string secondInput = Console.ReadLine();
//---------------------------------------------

//adding a dot character to input and conversion------
firstInput = firstInput.Replace('.', ',');
secondInput = secondInput.Replace('.', ',');

decimal firstNumber = Convert.ToDecimal(firstInput);
decimal secondNumber = Convert.ToDecimal(secondInput);
//----------------------------------------------------

//user input and interface-----------------------
Console.WriteLine("Enter your action: + - * / ");
string actionSelect = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Result:");
//-----------------------------------------------

//conditions for selecting an action--------------------
switch (actionSelect)
{
    case "+":
        Console.WriteLine( firstNumber + secondNumber );
        break;

    case "-":
        Console.WriteLine( firstNumber - secondNumber );
        break;

    case "*":
        Console.WriteLine( firstNumber * secondNumber);
        break;

    case "/":
        Console.WriteLine( firstNumber / secondNumber);
        break;

    default:
        Console.WriteLine( "Incorrect action!" );
        break;
}
//------------------------------------------------------