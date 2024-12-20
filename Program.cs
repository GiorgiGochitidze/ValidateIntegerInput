string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();

    bool readResultInt = int.TryParse(readResult, out numericValue);

    if (numericValue >= 5 && numericValue <= 10)
    {
        Console.WriteLine($"Your input value ({readResult}) has been accepted.");
        validNumber = true;
    }
    else if (readResultInt)
    {
        Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }

} while (validNumber == false);