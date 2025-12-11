
// program1--------------------------------------------------------------
int emNumber = 0;
int averageSalary = 0;

Console.WriteLine(" Program 1 started... ");
Console.WriteLine();
while (emNumber <= 4)
{
    Console.WriteLine("Enter salary " + ++emNumber + " employee:"); 
    string inputSalary = Console.ReadLine(); //user input salary
    int checkSalary = int.Parse(inputSalary); 
    averageSalary += checkSalary;
}
Console.WriteLine();
Console.WriteLine("Average salary = " + averageSalary / emNumber + "$"); //outputs average salary
Console.WriteLine();
Console.WriteLine(" Program 1 finished... ");

Console.WriteLine();
//-----------------------------------------------------------------------



// program2--------------------------------------------------------------
Console.WriteLine(" Program 2 started... ");
Console.WriteLine();

string numStars = "";
string Star = "*";
Console.WriteLine("Enter the number of rows:");
string userInput = Console.ReadLine(); //user input number of rows
int lineCount = int.Parse(userInput);
Console.WriteLine();

for (int i = 0; i < lineCount; ++i)
{
    Console.WriteLine(numStars += Star); //outputs stars
}

Console.WriteLine();
Console.WriteLine(" Program 2 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------



// program3--------------------------------------------------------------
Console.WriteLine(" Program 3 started...");
Console.WriteLine();

Console.WriteLine("Enter a number to search for prime numbers:");
string ussserInput = Console.ReadLine(); //inputs user number
int checkNumber = int.Parse(ussserInput);
Console.WriteLine();

for (int i = 1; i <= checkNumber; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0) //checking for a not prime number
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        Console.WriteLine(i); //outputs prime numbers till user number
}

Console.WriteLine();
Console.WriteLine(" Program 3 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------



// program4--------------------------------------------------------------
Console.WriteLine(" Program 4 started...");
Console.WriteLine();

Console.WriteLine("Enter your length of the fibo:");
string usserInput = Console.ReadLine(); //user inputs the length of the row fibo
int convNumber = int.Parse(usserInput);
Console.WriteLine();

int a = 0;      // first number
int b = 1;      // second number

for (int i = 0; i < convNumber; i++)
{
    Console.WriteLine(a);

    int next = a + b; // fibo algorithm
    a = b;            // number shifting
    b = next;
}

Console.WriteLine();
Console.WriteLine(" Program 4 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------



// program5--------------------------------------------------------------
Console.WriteLine(" Program 5 started...");
Console.WriteLine();

Console.WriteLine("Enter your morning hours:");
string hourMorning = Console.ReadLine(); // user inputs morning hours
int checkMorning = int.Parse(hourMorning);

Console.WriteLine("Enter your day hours:");
string hourDay = Console.ReadLine(); // user inputs day hours
int checkDay = int.Parse(hourDay);

Console.WriteLine("Enter your evening hours:");
string hourEvening = Console.ReadLine(); // user inputs evening hours
int checkEvening = int.Parse(hourEvening);

Console.WriteLine();
Console.WriteLine("Enter your hourlyRate:");
string hourlyRate = Console.ReadLine(); // user inputs average hourlyRate
int checkRate = int.Parse(hourlyRate);
Console.WriteLine();

int extraPay = checkRate / 10;
int myPay = 0;
int totalPay = 0;



for (int i = 1; i <= checkMorning; i++)
{
    Console.WriteLine(myPay = checkRate - extraPay); // outputs morning rate
    totalPay += myPay;
}

for (int i = 1; i <= checkDay; i++)
{
    Console.WriteLine(myPay = checkRate); // outputs day rate
    totalPay += myPay;
}

for (int i = 1; i <= checkEvening; i++)
{
    Console.WriteLine(myPay = checkRate + extraPay); // outputs evening rate
    totalPay += myPay;
}

Console.WriteLine();
Console.WriteLine($"Payday = {totalPay}$"); // outputs total payment per day

Console.WriteLine();
Console.WriteLine(" Program 5 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------



// program6--------------------------------------------------------------
Console.WriteLine(" Program 6 started...");
Console.WriteLine();

Console.WriteLine("Enter the number to multiply:");
string inputNumber = Console.ReadLine(); //user inputs the number
int checckNumber = int.Parse(inputNumber);
Console.WriteLine();

for (int i = 1; i <= 10; ++i)
{
    Console.WriteLine($" {checckNumber} * {i} = {checckNumber * i}"); //outputs the multitable till 10
}

Console.WriteLine();
Console.WriteLine(" Program 6 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------



// program7--------------------------------------------------------------
Console.WriteLine(" Program 7 started...");
Console.WriteLine();

Console.Write("Enter your number for the prime checking: ");
string useerInput = Console.ReadLine(); // user inputs his number
Console.WriteLine();

if (int.TryParse(useerInput, out int number))
{
    if (number < 2)
    {
        Console.WriteLine("It`s not a prime number!"); // outputs not a prime info
        return;
    }

    bool isPrime = true;

    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0) // checking for not a prime 
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
        Console.WriteLine("It`s a prime number!"); //outputs prime info
    else
        Console.WriteLine("It`s not a prime number!"); // outputs not a prime info
}
else
{
    Console.WriteLine("Wrong! Enter an integer!");
}

Console.WriteLine();
Console.WriteLine(" Program 7 finished... ");
Console.WriteLine();
//-----------------------------------------------------------------------