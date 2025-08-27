// See https://aka.ms/new-console-template for more information


/*
int a = 5;
int b = 10;
bool c = (a > b) ? true : false;
 ":" is called the conditional operator, it is used to assign a value to a variable based on a condition, it is a shorthand for an if-else statement.
Console.WriteLine(c);
*/



/*
int? i = null;
"?" is called the null - conditional operator, it is used to check if a variable is null before accessing its members, it is a shorthand for an if statement.
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
 Function "switch" is called the switch statement, it is used to select one of many code blocks to be executed.

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
 "and" is called the logical AND operator, it is used to combine two conditions, it returns true if both conditions are true.
 "or" is called the logical OR operator, it is used to combine two conditions, it returns true if at least one condition is true.
 "not" is called the logical NOT operator, it is used to negate a condition, it returns true if the condition is false.
 "is" is called the type pattern operator, it is used to check if a variable is of a certain type, it returns true if the variable is of the specified type.
 "not" can also be used with "is" to check if a variable is not of a certain type.
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
 "Value" is used to get the value of a nullable type, it throws an exception if the variable is null.
*/





/*
try
{

}
catch (Exception)
{

    throw;
}
"try" and "catch" are used for exception handling, it is used to handle errors in a program, it allows the program to continue running even if an error occurs.



float f = 5.5f;
"f" is used to indicate that a number is a float, it is used to differentiate between float and double types.
*/



/*
string e = "100";
int k = int.Parse(e);
 "Parse" is used to convert a string to a number, it throws an exception if the conversion fails.
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
 "TryParse" is used to convert a string to a number, it returns a boolean value indicating whether the conversion was successful or not, it does not throw an exception if the conversion fails.
 "out" is used to indicate that a variable is passed by reference, it allows a method to return multiple values.
*/



/*
int[] okak = new int[3];
okak[0] = 1;
okak[1] = 2;
okak[2] = 3;
 "[]" is used to indicate that a variable is an array, it is used to store multiple values in a single variable.
Console.WriteLine(okak[1]);

int[,] matrix = new int[2, 3];
matrix[0, 0] = 1;
matrix[0, 1] = 2;
matrix[0, 2] = 3;
matrix[1, 0] = 4;
matrix[1, 1] = 5;
matrix[1, 2] = 6;
Console.WriteLine(matrix[1, 2]);
 ", " is used to separate multiple values in an array, it is also used to separate multiple parameters in a method.
 " , " is also used to indicate that a variable is a multi-dimensional array, it is used to store data in a table format.
*/



/*
 "///" - This is used to create XML documentation comments, it is used to document code and generate documentation files.
 "//" - This is used to create single line comments, it is used to document code and make it more readable.
 "&&" - This is used to create logical AND operations, it is used to combine multiple conditions in an if statement.
 "&" - This is used to create bitwise AND operations, it is used to perform operations on individual bits of a number.
 "||" - This is used to create logical OR operations, it is used to combine multiple conditions in an if statement.
 "|" - This is used to create bitwise OR operations, it is used to perform operations on individual bits of a number.
 "^^" - This is used to create logical XOR operations, it is used to combine multiple conditions in an if statement.
 "^" - This is used to create bitwise XOR operations, it is used to perform operations on individual bits of a number.

".ToUpper()" - This is used to convert a string to uppercase, it is used to change the case of a string.
".ToLower()" - This is used to convert a string to lowercase, it is used to change the case of a string.
".Trim()" - This is used to remove whitespace from the beginning and end of a string, it is used to clean up a string.
".Substring()" - This is used to extract a substring from a string, it is used to get a portion of a string.
".Length" - This is used to get the length of a string, it is used to determine the number of characters in a string.
".Replace()" - This is used to replace a substring in a string with another substring, it is used to modify a string.
".Split()" - This is used to split a string into an array of substrings based on a specified delimiter, it is used to break a string into smaller parts.
".Contains()" - This is used to check if a string contains a specified substring, it is used to search for a substring in a string.
".StartsWith()" - This is used to check if a string starts with a specified substring, it is used to search for a substring at the beginning of a string.
".EndsWith()" - This is used to check if a string ends with a specified substring, it is used to search for a substring at the end of a string.
".IndexOf()" - This is used to get the index of the first occurrence of a specified substring in a string, it is used to find the position of a substring in a string.
".LastIndexOf()" - This is used to get the index of the last occurrence of a specified substring in a string, it is used to find the position of a substring in a string.
".Insert()" - This is used to insert a substring into a string at a specified index, it is used to add a substring to a string.
".Remove()" - This is used to remove a substring from a string, it is used to delete a portion of a string.
".ToString()" - This is used to convert a value to a string, it is used to display a value as a string.
".ToCharArray()" - This is used to convert a string to a character array, it is used to manipulate individual characters in a string.
".ToList()" - This is used to convert a string to a list of characters, it is used to manipulate individual characters in a string.
".ToArray()" - This is used to convert a string to an array of characters, it is used to manipulate individual characters in a string.
".Join()" - This is used to join an array of strings into a single string, it is used to combine multiple strings into one.
".Format()" - This is used to format a string using placeholders, it is used to create a string with dynamic content.
".CompareTo()" - This is used to compare two strings, it is used to determine the relative order of two strings.
".Equals()" - This is used to compare two strings for equality, it is used to determine if two strings are the same.
".GetHashCode()" - This is used to get the hash code of a string, it is used to create a unique identifier for a string.
".Clone()" - This is used to create a copy of a string, it is used to create a new instance of a string with the same value.
".CopyTo()" - This is used to copy a substring from a string to a character array, it is used to extract a portion of a string into an array.
".Normalize()" - This is used to normalize a string to a specified Unicode normalization form, it is used to ensure that a string is in a consistent format.
".PadLeft()" - This is used to pad a string with a specified character on the left side, it is used to align a string to the right.
".PadRight()" - This is used to pad a string with a specified character on the right side, it is used to align a string to the left.
".GetType()" - This is used to get the type of a string, it is used to determine the data type of a string.
".IsNullOrEmpty()" - This is used to check if a string is null or empty, it is used to validate a string before performing operations on it.
".IsNullOrWhiteSpace()" - This is used to check if a string is null, empty, or consists only of whitespace characters, it is used to validate a string before performing operations on it.
".Copy()" - This is used to create a copy of a string, it is used to create a new instance of a string with the same value.
".Intern()" - This is used to retrieve the system's reference to a specified string, it is used to optimize memory usage by reusing string instances.
".IsInterned()" - This is used to check if a specified string is interned, it is used to determine if a string instance is stored in the intern pool.
".Concat()" - This is used to concatenate two or more strings, it is used to combine multiple strings into one.
".Compare()" - This is used to compare two strings, it is used to determine the relative order of two strings.
".Empty" - This is used to get an empty string, it is used to represent a string with no characters.
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
"Start:" is a label, it is used to mark a specific section of code that can be jumped to using the "goto" statement.
"goto" is used to transfer control to a specified label, it is used to create loops and jump to specific sections of code.
Note: The use of "goto" is generally discouraged in modern programming due to potential readability and maintainability issues.
However, it can be useful in certain scenarios, such as breaking out of nested loops or implementing state machines.
*/



/*
int i = 3;
while (i > 0)
{
    Console.WriteLine(i);
    i--;
}
"while" is used to create a loop that continues as long as a specified condition is true, it is used to repeat a block of code multiple times.
*/




/*
do
{
    Console.WriteLine("Enter a number greater than 10:");
    int num = int.Parse(Console.ReadLine());
} while (num <= 10);
"do-while" is used to create a loop that executes a block of code at least once and continues as long as a specified condition is true, it is used to repeat a block of code multiple times.
*/



/*
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }
    Console.WriteLine(i);
}
 "for" is used to create a loop that iterates over a specified range of values, it is used to repeat a block of code multiple times.
 "continue" is used to skip the current iteration of a loop and move to the next iteration, it is used to control the flow of a loop.
*/

// waiting for part 15
