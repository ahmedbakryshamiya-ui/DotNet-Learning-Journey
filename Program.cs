// Author: Ahmed Bakry
// This is not the best code, but for a beginner, it meant real progress.

#region Data Types
/*float x = 1.6F;
double y = 1.6;
decimal z = 1.6M;
// bool = {false/true}

Console.WriteLine($"x = {x}, y = {y}, z = {z}");
Console.WriteLine(int.MinValue);
Console.WriteLine(int.MaxValue);
Console.ReadLine();*/
#endregion

#region Conversions
/*int intvar = 10;
double doublevar = 15.10;
Console.WriteLine("Before conversion:");
Console.WriteLine($"Integer : {intvar}  \n Double : {doublevar} ");
// implicit conversion
doublevar = intvar;
Console.WriteLine("After implicit conversion:");
Console.WriteLine($"Integer : {intvar}  \n Double : {doublevar} ");
// explicit conversion
intvar = (int)doublevar;
Console.WriteLine("After explicit conversion:");
Console.WriteLine($"Integer : {intvar}  \n Double : {doublevar} "); 

string age = "30";
int intvar1 =int.Parse(age);
Console.WriteLine($" Integer Value: {intvar1}");

int price = 100;
//string imputfaild =Convert.ToString(price);
Console.WriteLine(price.ToString());*/
#endregion

#region valye types
//Value types store the actual data directly in memory
//like int, float, double, bool, char, struct, enum, etc.
#endregion

#region reference types
// Reference types store a reference to the memory location of an object
//like  string class, array, delegate, interface, etc.
#endregion

#region Format 
/*using System.Text;

var message = string.Format("Hello, {0}!", "World");
Console.WriteLine(message);
Console.WriteLine("--------------------------------");
StringBuilder Name = new StringBuilder();
Name.Append("Ahmed");
Name.Append ("Bakry");
Console.WriteLine(Name);
Console.WriteLine(Name.Length);
Console.WriteLine(Name.Replace("Bakry", "Sayed"));
Console.WriteLine("--------------------------------");
Console.WriteLine("Number:{0:C}", 90);
Console.WriteLine("Number:{0:N}", 90);
Console.WriteLine("Number:{0:P}", 0.90);
Console.WriteLine("Number:{0:D5}", 90);
Console.WriteLine("Hexadecimal:{0:X}", 19287983);
Console.ReadLine();*/
#endregion

#region DataTime
/*DateTime myDate = DateTime.Now;
DateTime Date = new DateTime(2026, 3, 25);
Console.WriteLine(Date);
//Console.WriteLine(myDate);
string formattedDate = String.Format("DateTime is : {0:dd/mmmm/yyyy dddd HH:mm:ss tt}",myDate);
Console.WriteLine(formattedDate);*/
#endregion

#region DataOnly,TimeOnly
// DateOnly
/*DateOnly date = new DateOnly(2026, 3, 25);
Console.WriteLine(date);
Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.DayOfYear);
Console.WriteLine(date.AddMonths(1).AddYears(10));
var currentDate = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(currentDate);
Console.WriteLine("----------------------------");
// TimeOnly
TimeOnly evenIn = new TimeOnly(8, 0, 0);
TimeOnly evenOut = new TimeOnly(16, 0, 0);
Console.WriteLine(evenIn);
Console.WriteLine(evenOut);
TimeSpan span = evenOut - evenIn;
Console.WriteLine($"Duration: {span.TotalHours}");
Console.WriteLine($"Duration: {span.TotalMinutes}");
Console.ReadLine();*/
#endregion

#region  get Input From User
/*Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Name is {name}");

Console.WriteLine("What is your job?");
string Jop = Console.ReadLine();
Console.WriteLine($"Jop is {Jop}");

Console.WriteLine("Enter your current salary and desired salary:");
decimal currentSalary, desiredSalary;
currentSalary = Convert.ToDecimal( Console.ReadLine());
desiredSalary = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Current Salary: {currentSalary} , Desired Salary: {desiredSalary}");
Console.ReadLine();
//Example: Get the user's birthdate and display the day of the week, day, month, and year.
Console.WriteLine("Enter your birthdate:");
DateTime brithday = DateTime.Parse(Console.ReadLine());
Console.WriteLine(brithday.DayOfWeek);
Console.WriteLine($"{brithday.Day} Of {brithday:MMMM}  {brithday.Year}");

Console.ReadLine();*/
#endregion

#region Arithmetic Operators
/*int result;
int x = 10;int y = 3;

result = x + y;
Console.WriteLine($"Result: {result}");
result = x - y;
Console.WriteLine($"Result: {result}");
result = x * y;
Console.WriteLine($"Result: {result}");
result = x / y;
Console.WriteLine($"Result: {result}");
result = x % y;
Console.WriteLine($"Result: {result}");
Console.ReadLine();*/


#endregion

#region if 
/*using System.ComponentModel.Design;
using System.Threading.Channels;

int x = 13, y = 13;
if (x > y)
{

    Console.WriteLine("x is greater than y");
}
else if (x < y)
{
    Console.WriteLine("x is not greater than y");
}
else if (x == y)
{
    Console.WriteLine("x is equal to y");
}
    Console.ReadLine();*/

#endregion

#region Logical Operators
// AND have aporyrty than OR and Not have aporyrty than OR and AND
// AND Opeator (&&) 
//Console.WriteLine("Do you have a driver's license? (true/false)");
//bool hasLicense = bool.Parse(Console.ReadLine());
//Console.WriteLine("Do you know how to drive? (true/false)");
//bool KnowHow = bool.Parse(Console.ReadLine());
//if (hasLicense == true && KnowHow == true) // buy default hasLicense == true , KnowHow == true
//{
//    Console.WriteLine("You are qualified to drive.");
//}
//else
//{
//    Console.WriteLine("You are not qualified to drive.");
//}
// OR Operator (||)
//Console.WriteLine("Do you have a car? (true/false)"); 
//bool youHaveCar = bool.Parse(Console.ReadLine());
//if (hasLicense  && KnowHow  || youHaveCar  )
//{
//    Console.WriteLine("You are qualified to drive.");
//}
//else
//{
//    Console.WriteLine("You are not qualified to drive.");
//}
// Not Operator (!)
/*Console.WriteLine("Do you have an account? (true/false)");
bool username =bool.Parse(Console.ReadLine());
Console.WriteLine("Do you know your account password? (true/false)");
bool password = bool.Parse(Console.ReadLine());
Console.WriteLine("Do you have an email address? (true/false)");
bool email =bool.Parse(Console.ReadLine());

if ((username && email) || password) //( ) have aporyrty than all operators
{
    Console.WriteLine("You are qualified to login.");
}
else
{
    Console.WriteLine("You are not qualified to login.");
}


Console.ReadLine(); */
#endregion

#region Ternary Operator
/*int x = 10, y = 20;
if (x > y)
{
    Console.WriteLine("x is greater than y");
}
else
{
    Console.WriteLine("x is not greater than y");
}

var evenOrder = "";
evenOrder = (x%2==0) ? "even" : "odd";
Console.WriteLine($"{x} is {evenOrder}");
Console.WriteLine(x%2==0? $" {x} is even": $" {x} is odd");
var result = x > y ? "x is greater than y" : "x is not greater than y";
Console.WriteLine(result);
Console.ReadLine();*/
#endregion

#region Switch Statement
/*Console.WriteLine("Enter your temperature?");
var temp = double.Parse(Console.ReadLine());
switch (temp)
{
    case < 20:
        Console.WriteLine("It's cold.");
        break;
    case >= 20 and < 30:
        Console.WriteLine("It's Moderate.");
        break;
    case >= 30:
        Console.WriteLine("It's Hot.");
        break;
    default:
        Console.WriteLine("Invalid temperature."); 
        break;

}
// new switch expression in C# 8.0 and later
Console.WriteLine("Enter your temperature?");
var temp1 = double.Parse(Console.ReadLine()) switch
{
    < 20 => "It's cold.",
    >= 20 and < 30 => "It's Moderate.",
    >= 30 => "It's Hot." ,
    _ => "Invalid temperature.",// Default case
};
Console.WriteLine(temp1);
Console.ReadLine(); */
#endregion

#region Nullable Types
//int Num1 = null;
/*int? Num2 = null;
Nullable<int> Num3 = null;
var Num4 = ""; //Nullable String
//Null Coalescing Operator
double? Number = null;
double total = Number ?? 1;
Console.WriteLine($"Total: {total}");*/

#endregion

#region TryParse
/*using System.Threading.Channels;

//int n = int.Parse(Console.ReadLine());// if uswr write diffrent type =error but tryparse solve irror
int.TryParse(Console.ReadLine(), out int x); //if error happen x = 0
Console.WriteLine(x);
//if (x == 0)
//{
//    Console.WriteLine("Invalid input.");
//}
//else
//{
//    Console.WriteLine($"You entered is {x}");
//}
Console.WriteLine(x==0?"Invalid input.":$"You entered is {x}");
Console.ReadLine();
*/
#endregion

#region constants
//const int x = 10;
// x = 20; // This would cause a compile-time error since x is a constant
#endregion

#region  String Manipulation
/*string MovieName = "LORD oF the RINGs";
Console.WriteLine(MovieName);
// Length (property) 
Console.WriteLine(MovieName.Length);
//trim
Console.WriteLine(MovieName.Trim());
//indexes
Console.WriteLine(MovieName[5]);
//Upper Case
Console.WriteLine(MovieName.ToUpper().Trim());
//Lower Case
Console.WriteLine(MovieName.ToLower());
//Substring
//Replace
Console.WriteLine(MovieName.Replace("LORD", "Lord"));
//IndexOf
Console.WriteLine(MovieName.IndexOf("o"));
//lastIndexOf
Console.WriteLine(MovieName.LastIndexOf("o"));
//superstring
Console.WriteLine(MovieName.Substring(4, 10));
//remove
Console.WriteLine(MovieName.Remove(10));
//insert
Console.WriteLine(MovieName.Insert(0, "The "));
//Contains
Console.WriteLine(MovieName.Contains("LORD")); // Contains = boolean v
*/

#endregion

#region Escape Sequences 
/*Console.WriteLine("\"Ahmed\"");
Console.WriteLine("c:\\");
Console.WriteLine("\a");
Console.WriteLine("Ahmed is a \t Engineer");
*/
#endregion

#region Interpolated Verbatim Strings {all types of strings in this region}
/*string NormalString ="Ahmed\nBakry";
string VerbatimString = @"Ahmed
Bakry";
int age = 5;
//string concatenation
string concatenation = "Ahmed Bakry is "+age+" years old.";
string format = string.Format("Ahmed Bakry is {0} years old.", age);
string interpolation = $"Ahmed Bakry is {age} years old.";
Console.WriteLine(NormalString);
Console.WriteLine(VerbatimString);
Console.WriteLine(concatenation);
Console.WriteLine(format);
Console.WriteLine(interpolation);
string fileName ="employes";
string fileName1 ="C:\\Users\\Ahmed\\Documents\\file.txt";
string fileName2 = @"C:\Users\Ahmed\Documents\file.txt";
string fileName3 = @$"C:\Users\Ahmed\Documents\{fileName}.txt";
Console.ReadLine();*/

#endregion

#region For loop
/*
 for (initalization; condition; iteration)
{
    body of the loop
}

using System.Threading.Channels;

int i;
long num = long.Parse(Console.ReadLine());
for (i=0;i<=num;i++)
{
    
    Console.WriteLine((i%2==0) ? "i is even" :"i is odd ");
}*/
#endregion

#region foreach loop
/*var names = new string[] { "Ahmed", "Bakry", "Sayed" };
foreach (var name in names)
{
    Console.WriteLine(name);
}*/
#endregion

#region While and do-while loop
/*
while (condition)
{
    body of the loop
}*/
/*int x = 8;
while (x >= -8) 
{
   
    if (x<=1)
    {
        Console.WriteLine("Breaking the loop..");
        break;
    }
    
  Console.WriteLine($"Interation = {x}");
    x--;
    
}
Console.ReadLine();*/

/*do
{
    body of the loop
} while (condition);
*/
/*int i=0 , n=2 ,result;
do
{
    result = i * n;
    Console.WriteLine($"{i} * {n} = {result}");
    i++;
}while( i <=12);*/
#endregion

#region Nested Loops
/*for (int n = 1; n <= 12; n++)
{
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{n} × {i} = {n * i}");
    }
    Console.WriteLine("----------------");

    Console.WriteLine();
}*/
#endregion

#region Triangle Patterns
/*Console.WriteLine("Task 1");
for (int i = 1; i <= 12; i++)
{
    for (int k = 12; k >= i; k--)
    {
        Console.Write("  ");
       
    }
    for (int j = 1; j <= (2 * i) - 1; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
Console.WriteLine("---------------------");
Console.WriteLine("Task 2");
for (int i = 12; i >= 1; i--)
{
    for (int k = 12; k >= i; k--)
    {
        Console.Write("  ");

    }
    for (int j = 1; j <= (2 * i) - 1; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
Console.WriteLine("---------------------");
Console.WriteLine("Task 3");

int height = 12;

for (int i = 1; i <= height; i++)
{
    // المسافات الخارجية
    for (int k = 1; k <= height - i; k++)
        Console.Write(" ");

    if (i == 1)
    {
        Console.Write("*");
    }
    else if (i == height)
    {
        for (int j = 1; j <= 2 * height - 1; j++)
            Console.Write("*");
    }
    else
    {
        Console.Write("*");

        for (int s = 1; s <= 2 * i - 3; s++)
            Console.Write(" ");

        Console.Write("*");
    }

    Console.WriteLine();
}
Console.ReadLine();*/
#endregion

#region   Math Functions
/*int x = -10;
int a = 5;
double y = 3.5;
int z = 4;
Console.WriteLine("ceiling :" + Math.Ceiling(y));
Console.WriteLine("floor :" + Math.Floor(y));
Console.WriteLine("round :" + Math.Round(y));
Console.WriteLine("abs :" + Math.Abs(x));
Console.WriteLine("Multiplication :" + Math.BigMul(a, z));
Console.WriteLine("Max :" + Math.Max(x, y));
Console.WriteLine("Min :" + Math.Min(x, y));
Console.WriteLine("Square Root :" + Math.Sqrt(z));
Console.WriteLine("power :" + Math.Pow(a, z));
Console.WriteLine("Div Remainder :" + Math.DivRem(13, 3));*/
#endregion

#region Random Number Generation
/*Random random = new Random();
int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
Console.WriteLine($"Random Number: {randomNumber}");
Console.WriteLine($"Random Double: {random.NextDouble() * 100}"); // Generates a random double between 0.0 and 100.0
Console.ReadLine();*/
#endregion

#region Arrays
/*int[] numbers = { 1, 2, 3, 4, 5 };
int[] mobileNumbers = new int[12];
var names = new string[] { "Ali", "Bakry", "Sayed" };
Console.WriteLine(names[0]);
names[0] = "Ahmed";
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.ReadLine();*/
#endregion

#region Traversing 1D Array
/*var genders = new char[] { 'f','f', 'f','m','m','m','m','m'};
int Males = 0, Females = 0;
foreach (char gender in genders)
{
    if (gender == 'm')
        Males++;
    else if (gender =='f')
        Females++;
    
}
Console.WriteLine($" Numders of Males {Males} \n Numbers of Females {Females}" );*/
#endregion

#region Sorting Array  (Bubble Sort Algorithm)
/*int[] numbers = { 9, 8, 6, 4, 2, 3, 5, 1, 7, 10, -2, 100 };
int swap;

Console.WriteLine("Before Sorting");
foreach (var sw in numbers)
{
    Console.Write(sw + " ");
}
Console.WriteLine("\n Sorting process");
for (int k = 0; k < numbers.Length -1; k++)
{
    for (int i = 0; i < numbers.Length -1; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            swap = numbers[i + 1];
            numbers[i+1] = numbers[i];
           numbers[i] = swap;
        }
    }
}
Console.WriteLine("After Sorting");
foreach (var num in numbers)
{
    Console.Write(num + " ");
}
// easy way 
Console.WriteLine("\nBefore ");
int[] number = {9,7,5,3,1,2,4,6,8,0};
foreach (var item in number)
{
    Console.Write(item + " ");
}
Console.WriteLine("\nAfter");
Array.Sort(number);
//Array.Reverse(number);
foreach (var item in number)
{
    Console.Write(item + " ");
}
Console.ReadLine();*/
#endregion

#region Multidimensional Arrays (2D and 3D)
// 1D
/*int[] OneDimArray = new int[5] { 2, 3, 5, 6, 7 };
//2D 
int[,] twoDimArray = new int[2, 3];
                      //[0,1]       {0}            {1}
int[,] Matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//int[,] Matrix1 =  { { 1, 2, 3 }, { 4, 5, 6 } };

Console.WriteLine(Matrix[0,2]);  // 3
Console.WriteLine(Matrix[1, 2]); // 6 

Console.WriteLine("Matrix length = " + Matrix.Length);
Console.WriteLine("Matrix Rows =  " + Matrix.GetLength(0));
Console.WriteLine("Matrix Columns =  " + Matrix.GetLength(1));
Console.WriteLine("-------------------");
// matrix = [R =0,C=1]
for (int R = 0; R < Matrix.GetLength(0); R++) // Rows
{
    Console.WriteLine($"Row {R + 1}"); // number of row
    for (int C = 0; C < Matrix.GetLength(1); C++)
    {
       Console.WriteLine(Matrix[R, C] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("3D Arrays");
Console.WriteLine("-------------------");
                        //[ D, R, C]                          
int[,,] Matrix_3D = new int[ 2, 2, 2];
int[,,] Matrix1_3D =
{
    { {1,2,3},{4,5,6} } , // D = 0 
    { {7,8,9},{10,11,12} } // D = 1
};


Console.WriteLine(Matrix1_3D[0, 0, 1]); // 2
Console.WriteLine(Matrix1_3D[1, 1, 0]); // 10
for (int D = 0; D < Matrix1_3D.GetLength(0); D++)
{
    for (int R = 0; R < Matrix1_3D.GetLength(1); R++)
    {
        for (int C = 0; C < Matrix1_3D.GetLength(2); C++)
        {
            Console.WriteLine($"[{D},{R},{C}]: {Matrix1_3D[D, R, C]}");
        }
    }
}
Console.ReadLine();*/

#endregion

#region Jagged Arrays 
/*int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[] { 67,34,78 };
jaggedArray[1] = new int[] { 32, 45 };
int[][] jaggedArray1 =
{
     new int[] { 34,78 }, // 0
     new int[] { 67,34,78,46,87 }, //1
     new int[] { 67,34,78,23 }//2
};
Console.WriteLine(jaggedArray1[2][3]);

for (int i = 0; i < jaggedArray1.Length; i++)
{
    Console.WriteLine($"Array {i+1}");
    for (int j = 0; j <jaggedArray1[i].Length ; j++)
    {
        Console.Write(jaggedArray1[i][j] +",");
            
    }
    Console.WriteLine();
}
Console.ReadLine();*/
#endregion

#region Jagged Multidimensional Arrays 
/*int[][,] jagged2DArray =
{
   new int[,] { {1,2 },{3,4 } },
   new int[,] { {5,6},{7,8} }
};*/
#endregion

#region Ranges and Indices
// Indices = ^                          Normal cunt   Indices cunt
/*var cities = new string[] { "Alex",   // 0             4
                             "Cairo", // 1             3
                             "KFS",   // 2             2
                           "Nasr City"// 3             1
                            };

var lastCity = cities[3];
//Console.WriteLine(lastCity); // Nasr City 
//lastCity = cities[^3];
//Console.WriteLine(lastCity); // Cairo
foreach (var city in cities)
{
    Console.WriteLine(city);
}
Console.WriteLine("----------------");
//var visitedCities = cities[0..4];
//var visitedCities = cities[..];
var visitedCities = cities[^4..^0];
foreach (var city in visitedCities)
{
    Console.WriteLine(city);
}
Console.WriteLine("----------------");
// Rang (Data type)
Range RangCities = 0..4;
Console.WriteLine(RangCities.GetType());
Console.WriteLine(RangCities.Start);
Console.WriteLine(RangCities.End);
var lastOfCity = cities[RangCities];
foreach (var item in lastOfCity)
{
    Console.WriteLine(item);
}

Console.ReadLine();*/
#endregion
