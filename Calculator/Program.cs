void CalculatorApp()
{
    // Declare the variables and initialise them to 0.
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    // Get user input for numbers
    Console.WriteLine("Type in the first number, and then press Enter");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type the second number, and then press Enter");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    // Show the menu
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");

    // Get user's menu choice
    choice = Convert.ToInt32(Console.ReadLine());

    // *** THE IF-ELSE DECISION LOGIC ***
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }
}