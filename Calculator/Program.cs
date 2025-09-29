// See https://aka.ms/new-console-template for more information

// Ask the user to type the first number.
Console.WriteLine("Type in the first number, and then press Enter");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type the second number, and then press Enter");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// Perform the calculation
int result = firstNumber + secondNumber;

// Output the answer to the console
Console.WriteLine("Adding {0} and {1} gives the answer {2}", firstNumber, secondNumber, result);
Console.ReadKey();