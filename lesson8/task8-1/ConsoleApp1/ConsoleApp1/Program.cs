


//Program1///////////////////////////////////////////////////////////////

Console.WriteLine();
Console.WriteLine("Program 1 started.............");

int[] array = { 1, 6, 3, 5, 4, 2 };

int max = int.MinValue;
int secondMax = int.MinValue;

foreach (int number in array)
{
    if (number > max)
    {
        secondMax = max;
        max = number;
    }
    else if (number > secondMax && number < max)
    {
        secondMax = number;
    }
}
Console.WriteLine();
Console.WriteLine("Second largest element: " + secondMax);
Console.WriteLine();
Console.WriteLine("Program 1 finished.............");

//Program1end///////////////////////////////////////////////////////////////


//Program2///////////////////////////////////////////////////////////////

Console.WriteLine();
Console.WriteLine("Program 2 started.............");
Console.WriteLine();

int[,] array2 =
{
    { 9, 4, 7 },
    { 1, 3, 8 },
    { 6, 2, 5 }
};

int rows = array2.GetLength(0);
int cols = array2.GetLength(1);

// bubble sort
for (int i = 0; i < rows * cols - 1; i++)
{
    for (int j = i + 1; j < rows * cols; j++)
    {
        int iRow = i / cols;
        int iCol = i % cols;

        int jRow = j / cols;
        int jCol = j % cols;

        if (array2[iRow, iCol] > array2[jRow, jCol])
        {
            int temp = array2[iRow, iCol];
            array2[iRow, iCol] = array2[jRow, jCol];
            array2[jRow, jCol] = temp;
        }
    }
}

// output result
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(array2[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Program 2 finished.............");

//Program2end///////////////////////////////////////////////////////////////


/*
//Program3///////////////////////////////////////////////////////////////

using System;

class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        Console.Write("Enter the index to delete: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine();
        // checking the index
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Wrong index!");
            return;
        }

        // new array - 1 element
        int[] newArray = new int[array.Length - 1];

        int newIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (i == index)
                continue; // pass the element to delete

            newArray[newIndex] = array[i];
            newIndex++;
        }

        // output result
        Console.WriteLine("New array:");
        Console.WriteLine();
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

    }

}

//Program3end///////////////////////////////////////////////////////////////
*/

/*
//Program4///////////////////////////////////////////////////////////////

using System;

class Program
{
    static void Main()
    {

        Console.WriteLine();
        int[,] array =
        {
            { 1,  2,  3 },
            { 4,  5,  6 },
            { 7,  8,  9 }
        };

        int size = array.GetLength(0);
        int sumMainDiagonal = 0;
        int sumSideDiagonal = 0;

        for (int i = 0; i < size; i++)
        {
            sumMainDiagonal += array[i, i];                 // main diagonal
            sumSideDiagonal += array[i, size - 1 - i];      // side diagonal
        }

        Console.WriteLine("Main diagonal: " + sumMainDiagonal);
        Console.WriteLine("Side diagonal: " + sumSideDiagonal);
        Console.WriteLine("Sum of diagonals: " + (sumMainDiagonal + sumSideDiagonal));
    }
}

// Program4end///////////////////////////////////////////////////////////////
*/



