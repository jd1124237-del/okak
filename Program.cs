// See https://aka.ms/new-console-template for more information
//int a = 5;
//int b = 10;
//bool c = (a > b) ? true : false;
// ":" is called the conditional operator, it is used to assign a value to a variable based on a condition, it is a shorthand for an if-else statement.
//Console.WriteLine(c);

//int? i = null;
// "?" is called the null-conditional operator, it is used to check if a variable is null before accessing its members, it is a shorthand for an if statement.

int y = 8;
switch(y)
{
    case > 0 and < 5:
        Console.WriteLine("y is between 0 and 5");
        break;
    case >= 5 and <= 10:
        Console.WriteLine("y is between 5 and 10");
        break;
    default:
        Console.WriteLine("y is greater than 10");
        break;
}
// Function "switch" is called the switch statement, it is used to select one of many code blocks to be executed.

// "and" is called the logical AND operator, it is used to combine two conditions, it returns true if both conditions are true.
// "or" is called the logical OR operator, it is used to combine two conditions, it returns true if at least one condition is true.
// "not" is called the logical NOT operator, it is used to negate a condition, it returns true if the condition is false.
// "is" is called the type pattern operator, it is used to check if a variable is of a certain type, it returns true if the variable is of the specified type.
// "not" can also be used with "is" to check if a variable is not of a certain type.
// Example:
object obj = "Hello";
if (obj is not int)
{
    Console.WriteLine("obj is not an int");
}
int h = 8;