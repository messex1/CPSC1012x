///	<summary>
///	Purpose: CPSC1012 Assignment 1 - Future savings Goal Calculator
///	input: target amount, interest rate, number of years to save
///	output: calculated monthly contribution to reach target goal/ savings goal
/// process(es):	
/// Author: Michael Essex
/// Last modified: 2023.06.10
///	</summary>



// Prompt the user for input
Console.WriteLine("|=========================================|");
Console.WriteLine("|=    Future Goal Savings Calculator     =|");
Console.WriteLine("|=========================================|");
Console.WriteLine();

Console.Write("[Enter future target amount: ");
double targetGoal = double.Parse(Console.ReadLine());

Console.Write("[Enter the annual interest rate: ");
double interestRate = double.Parse(Console.ReadLine()) / 100.0;

Console.Write("[Enter the number of years to save (whole number): ");
int numYears = int.Parse(Console.ReadLine());

// Calculate monthly contribution
double monthlyInterestRate = interestRate / 12.0;
int numContributions = numYears * 12;

double contributionAmount = targetGoal * (monthlyInterestRate / (Math.Pow(1 + monthlyInterestRate, numContributions) - 1));

// Display the calculated contribution
Console.WriteLine();
Console.WriteLine($"Monthly contributiion to reach ${targetGoal:N2} in {numYears} year(s) is ${contributionAmount:F2}.");

// Wait for user input to exit
Console.WriteLine();
Console.WriteLine("Press any key to continue...");
Console.ReadKey();



///	<summary>
///	Purpose: CPSC1012 Assignment 1 - Future savings Goal Calculator
///	input: target amount, interest rate, number of years to save
///	output: calculated monthly contribution to reach target goal/ savings goal
/// process(es):	
/// Author: Michael Essex
/// Last modified: 2023.06.10
///	</summary>