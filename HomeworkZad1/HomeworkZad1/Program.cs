using System.ComponentModel.Design;
using System.Text;

Console.Write("What would you like the program to do?: \n 1. Output a specific square \n 2. Output all squares \n Which one would you like?[1/2]: ");

int answer = 0;
try
{
    answer = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid Input");
    return;
}

//Outcomes depending on answer
switch (answer)
{
    case 1:

        Console.Write("Enter a chessboard square and see how much wheat is on it (Example: B7): ");
        string squareChessboard = Console.ReadLine();
        int heightLocation = 0;

        //Checking if a value has been input
        try
        {
            //Changing the character to uppercase so it outputs the correct ASCII code
            heightLocation = (Char.ToUpper(squareChessboard[0])) - 65;
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid input!");
            return;
        }
        //Checking if input value is between A1-H8
        if ((heightLocation < 0 || heightLocation > 7) || (squareChessboard.Length > 2 || squareChessboard.Length < 0))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        //Calculation for output for the specific square
        int widthLocation = squareChessboard[1] - 48;
        int squareNumber = widthLocation + (heightLocation * 8);
        ulong wheatOnSquare = (ulong)Math.Pow(2, squareNumber - 1);

        //Output for specific square
        Console.WriteLine($"Number of wheat on square {squareChessboard.ToUpper()}: {wheatOnSquare}");

        break;

    case 2:
        int widthLetter = 65;
        ulong numberOfWheat = 1;

        //Loop to count the width of the board (A-H) and to change to a new line after 8 squares have been calculated
        for (int widthChessboard = 1; widthChessboard <= 8; widthChessboard++)
        {
            //Loop to calculate the number of wheat on each square
            for (int heightChessboard = 1; heightChessboard <= 8; heightChessboard++)
            {
                Console.Write($"{(char)widthLetter}{heightChessboard}: {numberOfWheat}| ");
                numberOfWheat *= 2;
            }
            Console.WriteLine();
            widthLetter++;
        }
        break;

    default:
        Console.WriteLine("Invalid Input");
        break;
}

