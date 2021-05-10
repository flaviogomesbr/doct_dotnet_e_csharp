using System;

for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}
    
    Console.WriteLine();

for (char column = 'a'; column < 'k'; column++)
{

    Console.WriteLine($"The column is {column}");
}

    Console.WriteLine();

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
