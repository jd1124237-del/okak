// See https://aka.ms/new-console-template for more information


/*
int a = 5;
int b = 10;
bool c = (a > b) ? true : false;
// ":" is called the conditional operator, it is used to assign a value to a variable based on a condition, it is a shorthand for an if-else statement.
Console.WriteLine(c);
*/



/*
int? i = null;
// "?" is called the null - conditional operator, it is used to check if a variable is null before accessing its members, it is a shorthand for an if statement.
*/



/*
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

Console.WriteLine("Enter a number:");
int e = int.Parse(Console.ReadLine());
switch (e)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Why so small :(");
        break;
    default:
        Console.WriteLine("You did not enter a number between 1 and 5");
        break;
}
*/



/*
// "and" is called the logical AND operator, it is used to combine two conditions, it returns true if both conditions are true.
// "or" is called the logical OR operator, it is used to combine two conditions, it returns true if at least one condition is true.
// "not" is called the logical NOT operator, it is used to negate a condition, it returns true if the condition is false.
// "is" is called the type pattern operator, it is used to check if a variable is of a certain type, it returns true if the variable is of the specified type.
// "not" can also be used with "is" to check if a variable is not of a certain type.
 Example:
object obj = "Hello";
if (obj is not int)
{
    Console.WriteLine("obj is not an int");
}
*/



/*
int? h = null;
int j = h.Value;
 int j = h ?? 0; // This will not throw an exception, it will return 0 if h is null.  
 int j = (int)h; // This will throw an exception if h is null.
 int j = h.GetValueOrDefault(); // This will not throw an exception, it will return 0 if h is null.
// "Value" is used to get the value of a nullable type, it throws an exception if the variable is null.
*/





/*
try
{
    int result = 10 / 9;
    Console.WriteLine(result);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    Console.WriteLine("This code always executes.");
}
// "try" is used to define a block of code that may throw an exception, it is used to handle exceptions and prevent the program from crashing.
// "catch" is used to define a block of code that handles exceptions, it is used to catch and handle specific exceptions.
// "finally" is used to define a block of code that always executes, it is used to clean up resources and perform final actions regardless of whether an exception was thrown or not.
*/




/*
float f = 5.5f;
// "f" is used to indicate that a number is a float, it is used to differentiate between float and double types.
*/



/*
string e = "100";
int k = int.Parse(e);
// "Parse" is used to convert a string to a number, it throws an exception if the conversion fails.

string m = "100jim";
int r = 0;
bool result = int.TryParse(m, out r);
if (result)
{
    Console.WriteLine(r);
}
else
{
    Console.WriteLine("Conversion failed");
}
// "TryParse" is used to convert a string to a number, it returns a boolean value indicating whether the conversion was successful or not, it does not throw an exception if the conversion fails.
// "out" is used to indicate that a variable is passed by reference, it allows a method to return multiple values.
*/



/*
int[] okak = new int[3];
okak[0] = 1;
okak[1] = 2;
okak[2] = 3;
// "[]" is used to indicate that a variable is an array, it is used to store multiple values in a single variable.
Console.WriteLine(okak[1]);

int[,] matrix = new int[2, 3];
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
Console.WriteLine(matrix[1, 2]);
// ", " is used to separate multiple values in an array, it is also used to separate multiple parameters in a method.
// " , " is also used to indicate that a variable is a multi-dimensional array, it is used to store data in a table format.
*/



/*
// "///" - This is used to create XML documentation comments, it is used to document code and generate documentation files.
// "//" - This is used to create single line comments, it is used to document code and make it more readable.
// "&&" - This is used to create logical AND operations, it is used to combine multiple conditions in an if statement.
// "&" - This is used to create bitwise AND operations, it is used to perform operations on individual bits of a number.
// "||" - This is used to create logical OR operations, it is used to combine multiple conditions in an if statement.
// "|" - This is used to create bitwise OR operations, it is used to perform operations on individual bits of a number.
// "^^" - This is used to create logical XOR operations, it is used to combine multiple conditions in an if statement.
// "^" - This is used to create bitwise XOR operations, it is used to perform operations on individual bits of a number.

//".ToUpper()" - This is used to convert a string to uppercase, it is used to change the case of a string.
//".ToLower()" - This is used to convert a string to lowercase, it is used to change the case of a string.
//".Trim()" - This is used to remove whitespace from the beginning and end of a string, it is used to clean up a string.
//".Substring()" - This is used to extract a substring from a string, it is used to get a portion of a string.
//".Length" - This is used to get the length of a string, it is used to determine the number of characters in a string.
//".Replace()" - This is used to replace a substring in a string with another substring, it is used to modify a string.
//".Split()" - This is used to split a string into an array of substrings based on a specified delimiter, it is used to break a string into smaller parts.
//".Contains()" - This is used to check if a string contains a specified substring, it is used to search for a substring in a string.
//".StartsWith()" - This is used to check if a string starts with a specified substring, it is used to search for a substring at the beginning of a string.
//".EndsWith()" - This is used to check if a string ends with a specified substring, it is used to search for a substring at the end of a string.
//".IndexOf()" - This is used to get the index of the first occurrence of a specified substring in a string, it is used to find the position of a substring in a string.
//".LastIndexOf()" - This is used to get the index of the last occurrence of a specified substring in a string, it is used to find the position of a substring in a string.
//".Insert()" - This is used to insert a substring into a string at a specified index, it is used to add a substring to a string.
//".Remove()" - This is used to remove a substring from a string, it is used to delete a portion of a string.
//".ToString()" - This is used to convert a value to a string, it is used to display a value as a string.
//".ToCharArray()" - This is used to convert a string to a character array, it is used to manipulate individual characters in a string.
//".ToList()" - This is used to convert a string to a list of characters, it is used to manipulate individual characters in a string.
//".ToArray()" - This is used to convert a string to an array of characters, it is used to manipulate individual characters in a string.
//".Join()" - This is used to join an array of strings into a single string, it is used to combine multiple strings into one.
//".Format()" - This is used to format a string using placeholders, it is used to create a string with dynamic content.
//".CompareTo()" - This is used to compare two strings, it is used to determine the relative order of two strings.
//".Equals()" - This is used to compare two strings for equality, it is used to determine if two strings are the same.
//".GetHashCode()" - This is used to get the hash code of a string, it is used to create a unique identifier for a string.
//".Clone()" - This is used to create a copy of a string, it is used to create a new instance of a string with the same value.
//".CopyTo()" - This is used to copy a substring from a string to a character array, it is used to extract a portion of a string into an array.
//".Normalize()" - This is used to normalize a string to a specified Unicode normalization form, it is used to ensure that a string is in a consistent format.
//".PadLeft()" - This is used to pad a string with a specified character on the left side, it is used to align a string to the right.
//".PadRight()" - This is used to pad a string with a specified character on the right side, it is used to align a string to the left.
//".GetType()" - This is used to get the type of a string, it is used to determine the data type of a string.
//".IsNullOrEmpty()" - This is used to check if a string is null or empty, it is used to validate a string before performing operations on it.
//".IsNullOrWhiteSpace()" - This is used to check if a string is null, empty, or consists only of whitespace characters, it is used to validate a string before performing operations on it.
//".Copy()" - This is used to create a copy of a string, it is used to create a new instance of a string with the same value.
//".Intern()" - This is used to retrieve the system's reference to a specified string, it is used to optimize memory usage by reusing string instances.
//".IsInterned()" - This is used to check if a specified string is interned, it is used to determine if a string instance is stored in the intern pool.
//".Concat()" - This is used to concatenate two or more strings, it is used to combine multiple strings into one.
//".Compare()" - This is used to compare two strings, it is used to determine the relative order of two strings.
//".Empty" - This is used to get an empty string, it is used to represent a string with no characters.
*/




/*
Start:
Console.WriteLine("write an \"okak\"");   
    string input = Console.ReadLine();
switch (input)
    {
        case "okak":
            Console.WriteLine("Good boy");
        break;
    default:
            Console.WriteLine("not okak");
            goto Start;
}
//"Start:" is a label, it is used to mark a specific section of code that can be jumped to using the "goto" statement.
//"goto" is used to transfer control to a specified label, it is used to create loops and jump to specific sections of code.
//Note: The use of "goto" is generally discouraged in modern programming due to potential readability and maintainability issues.
//However, it can be useful in certain scenarios, such as breaking out of nested loops or implementing state machines.
*/



/*
int i = 3;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
// "while" is used to create a loop that continues as long as a specified condition is true, it is used to repeat a block of code multiple times.
*/




/*
do
{
    Console.WriteLine("Enter a number greater than 10:");
    int num = int.Parse(Console.ReadLine());
} while (num <= 10);
// "do-while" is used to create a loop that executes a block of code at least once and continues as long as a specified condition is true, it is used to repeat a block of code multiple times.
*/



/*
for (int i = 0; i <= 20; i++)
{
    if (i%2 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}
// "for" is used to create a loop that iterates over a specified range of values, it is used to repeat a block of code multiple times.
// "continue" is used to skip the current iteration of a loop and move to the next iteration, it is used to control the flow of a loop.
*/



/*
int[] n = new int[3];
n[0] = 1;
n[1] = 20;
n[2] = 300;

foreach (int number in n)
{
    Console.WriteLine(number);
}
//"foreach" is used to iterate over a collection of items, it is used to repeat a block of code for each item in the collection.
*/



/*
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}
//"break" is used to exit a loop or switch statement, it is used to control the flow of a program.
*/



/*
class MyClass
{
    public static void Main()
    {
        MyClass.Mn(90);

        MyClass ok = new MyClass();
        int ggg = ok.Add(50, 10);
        Console.WriteLine(ggg);

    }
    public int Add(int a, int b)
    {
        return a + b;
    }

    public static void Mn(int t)
    {
        for (int i = 1; i <= 400; i++)
        {
            if (i == t)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}


//"public" is an access modifier, it is used to specify the accessibility of a class, method, or variable. It allows access from any other code in the same assembly or another assembly that references it.
//"static" is a keyword used to declare a member that belongs to the type itself rather than to a specific object. It allows access without creating an instance of the class.
//"void" is a return type that indicates a method does not return a value. It is used for methods that perform actions but do not produce a result.

*/



/*
class Program
{
    public static void Main()
    {
        int i = 0;
        Okak(i);
        Console.WriteLine(i);


        int r = 0;
        Otak(ref r);
        Console.WriteLine(r);


        int total = 0;
        int product = 0;
        Calculate(100, 68, out total, out product);
        Console.WriteLine("Sum = {0} && Product = {1}", total, product);

        int[] Numbers = new int[5];
        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;
        Numbers[3] = 4;
        Numbers[4] = 5;
        ParamsMethod(Numbers);
        ParamsMethod(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

    }
    public static void Okak(int z)
    {
        z = 508;
    }


    public static void Otak(ref int y)
    {
        y = 508;
    }


    public static void Calculate(int q, int u, out int sum, out int product)
    {
        sum = q + u;
        product = q * u;
    }
    public static void ParamsMethod(params int[] Numbers)// has to be the last parameter :)
    {
        Console.WriteLine("There are {0} elements", Numbers.Length);
        foreach (int b in Numbers)
        {
            Console.WriteLine(b);
        }
    }
}
//"ref" is used to pass a variable by reference, it allows a method to modify the value of the variable outside of its scope.
//"out" is used to pass a variable by reference, it allows a method to return multiple values.
//"params" is used to specify a variable number of arguments, it allows a method to accept a variable number of parameters as an array.
*/



/*
Random rnd = new Random();

// Generate a random integer between 1 and 100
int randomNumber = rnd.Next(1, 101);

// Generate a random double between 0.0 and 1.0
double randomDouble = rnd.NextDouble();

Console.WriteLine($"Random Integer: {randomNumber}");
Console.WriteLine($"Random Double: {randomDouble}");
// "Random" is a class used to generate pseudo-random numbers, it provides methods to generate random integers and floating-point numbers.
// "Next" is a method of the Random class that generates a random integer within a specified range.
*/



/*
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
List<string> k = new List<string> { "okak", "otak", "kak" };
List<double> d = new List<double> { 1.1, 2.2, 3.3 };
List<char> c = new List<char> { 'a', 'b', 'c' };
List<bool> b = new List<bool> { true, false, true };
List<float> f = new List<float> { 1.1f, 2.2f, 3.3f };

foreach (int number in numbers)
{
    Console.WriteLine($"Square of {number} is {number * number}");
}
// "using" is used to include namespaces in the program, it allows access to classes and methods defined in those namespaces.
// "List<T>" is a generic collection class that represents a list of objects that can be accessed by index, it provides methods to manipulate the list such as adding, removing, and searching for items.
// "float" is a data type that represents a single-precision floating-point number, it is used to store decimal values with less precision than double.
*/



/*
Random rnd = new Random();
int randomNumber;
for (int i = 1; i <= 10000000000; i++)
{
    for (int j = 1; j <= 10000000000; j++)
    {
        randomNumber = rnd.Next(1, 1000000000000000000000001);
        Console.Write($"{i * j * randomNumber * randomNumber}\t");
    }
    Console.WriteLine(); // Move to the next line after each row
}
// "\t" is used to insert a tab space in the output, it is used to format the output for better readability.
// "$" is used to create an interpolated string, it allows embedding expressions inside string literals for easier formatting.
*/



/*
string GetDayName(int dayNumber) => dayNumber switch
{
    1 => "Monday",
    2 => "Tuesday",
    3 => "Wednesday",
    4 => "Thursday",
    5 => "Friday",
    6 => "Saturday",
    7 => "Sunday",
    _ => "Unknown"
};
Console.WriteLine(GetDayName(3));
// "=>" is called the lambda operator, it is used to define a lambda expression, it is a shorthand for a method that takes parameters and returns a value.
*/



/*
int Add(int a, int b)
{
    return a + b;
}
int d = Add(5, 10);
Console.WriteLine(d);
// "return" is used to return a value from a method, it is used to exit a method and pass a value back to the caller.
*/



/*
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // outer list
        List<List<int>> rolls = new List<List<int>>();

        for (int i = 0; i < 5; i++) // 5 rolls
        {
            List<int> currentRoll = new List<int>(); // new "set of variables"

            for (int j = 0; j < 3; j++) // 3 variables per roll
            {
                currentRoll.Add((i + 1) * (j + 1));
            }

            rolls.Add(currentRoll);
        }

        // print everything
        for (int i = 0; i < rolls.Count; i++)
        {
            Console.WriteLine($"Roll {i + 1}:");
            for (int j = 0; j < rolls[i].Count; j++)
            {
                Console.WriteLine($"  rolls[{i}][{j}] = {rolls[i][j]}");
            }
        }
    }
}
// This code creates a list of lists to represent multiple rolls, each containing several variables, and prints them out in a structured format.
// This code is example for understanding nested collections and loops in C#.
*/
















// waiting for part 18
