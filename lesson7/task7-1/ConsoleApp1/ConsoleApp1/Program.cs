
Console.WriteLine();

//program 1///////////////////////////////////////////////////////////////////
Console.WriteLine("Program 1 started............");

int[] nums1 = new int[10]; //create array
Random randNum = new Random();



for ( int i = 0; i < nums1.Length; i++ )
{
    nums1[i] = randNum.Next(-10, 10);
   

    if (i % 2 == 0) //special condition for the paired index
        Console.WriteLine(nums1[i]);
}

Console.WriteLine("Program 1 finished............");
Console.WriteLine();
//////////////////////////////////////////////////////////////////////////////


//program 2///////////////////////////////////////////////////////////////////
Console.WriteLine("Program 2 started............");
Console.WriteLine();

int[] nums2 = new int[10];
Random randNum2 = new Random();

for (int i = 0; i < nums2.Length; i++)
{
    nums2[i] = randNum2.Next(-10, 10);

    Console.WriteLine(nums2[i]);
}


bool isNonNegative = false;
int sum = 0;
foreach (int num in nums2)
{
    sum += num;
}
Console.WriteLine();
Console.WriteLine("Sum of elements: " + sum);

if (sum >= 0) //checking for non-negative
{
    Console.WriteLine($"{!isNonNegative}, the number is non-negative!");
}

else {
    Console.WriteLine("The number less than zero!");
}
Console.WriteLine();
Console.WriteLine("Program 2 finished............");
Console.WriteLine();
//////////////////////////////////////////////////////////////////////////////


//program 3///////////////////////////////////////////////////////////////////
Console.WriteLine("Program 3 started............");
Console.WriteLine();

int[,] table = new int[9, 9];

// filling in the table
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        table[i, j] = (i + 1) * (j + 1); // starting with 1
    }
}

// table output
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(table[i, j].ToString().PadLeft(3)); // conversion for formatting
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Program 3 finished............");
Console.WriteLine();
//////////////////////////////////////////////////////////////////////////////


//program 4///////////////////////////////////////////////////////////////////
Console.WriteLine("Program 4 started............");
Console.WriteLine();

int[,] array2 = new int[5, 5 ];

Random randNum3 = new Random();

for (int i = 0; i < 5; i++) {
    
    for (int j = 0; j < 5; j++) 
    {
        array2[i, j] = randNum3.Next(7, 21);
        Console.Write(array2[i, j].ToString().PadLeft(3));
    }
    Console.WriteLine();
}



// Initialization min and max
int min = array2[0, 0];
int max = array2[0, 0];

int minRow = 0, minCol = 0;
int maxRow = 0, maxCol = 0;

// Searching min and max
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array2[i, j] < min)
        {
            min = array2[i, j];
            minRow = i;
            minCol = j;
        }

        if (array2[i, j] > max)
        {
            max = array2[i, j];
            maxRow = i;
            maxCol = j;
        }
    }
}


// Output results
Console.WriteLine();
Console.WriteLine($"Min element: {min}");
Console.WriteLine($"Coordinates of the min: [{minRow}, {minCol}]");
Console.WriteLine();
Console.WriteLine($"Max element: {max}");
Console.WriteLine($"Coordinates of the max: [{maxRow}, {maxCol}]");

Console.WriteLine();
Console.WriteLine("Program 4 finished............");
Console.WriteLine();
//////////////////////////////////////////////////////////////////////////////


//program 5///////////////////////////////////////////////////////////////////
Console.WriteLine("Program 5 started............");
Console.WriteLine();

Console.Write("Enter number of days: ");
int days = int.Parse(Console.ReadLine());

// Start day - Monday!
Day startDay = Day.Monday;

// Shifting days in a circle
Day resultDay = (Day)(((int)startDay + days) % 7);

Console.WriteLine($"Result day: {resultDay}");

Console.WriteLine();
Console.WriteLine("Program 5 finished............");
Console.WriteLine();


enum Day
{
    Monday = 0,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

//////////////////////////////////////////////////////////////////////////////






