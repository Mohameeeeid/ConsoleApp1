
using System;

// =============================
// Q01 - Class and Object
// =============================

Console.WriteLine("===== Q01 =====");

Book book = new Book();
book.Title = "C# Basics";
book.Pages = 464;

object myObject = book;

Console.WriteLine(myObject);


// =============================
// Q02 - Object Methods
// =============================

Console.WriteLine("\n===== Q02 =====");

Console.WriteLine("ToString: " + book.ToString());
Console.WriteLine("Equals: " + book.Equals(book));
Console.WriteLine("GetHashCode: " + book.GetHashCode());
Console.WriteLine("GetType: " + book.GetType());


// =============================
// Q03 - Compile-Time Error
// =============================

Console.WriteLine("\n===== Q03 =====");

// Wrong: int pages = "464";
// Correct:
int pages = 464;

Console.WriteLine("Pages: " + pages);


// =============================
// Q04 - Try Catch Finally
// =============================

Console.WriteLine("\n===== Q04 =====");

try
{
    int a = 10;
    int b = 0;

    int result = a / b;

    Console.WriteLine(result);
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}
finally
{
    Console.WriteLine("Done");
}


// =============================
// Q05 - Implicit Conversion
// =============================

Console.WriteLine("\n===== Q05 =====");

int pages5 = 300;
double totalPages = pages5;

Console.WriteLine("Double: " + totalPages);


// =============================
// Q06 - Explicit Casting
// =============================

Console.WriteLine("\n===== Q06 =====");

double price = 49.99;
int newPrice = (int)price;

Console.WriteLine("Price after casting: " + newPrice);


// =============================
// Q07 - Convert Class
// =============================

Console.WriteLine("\n===== Q07 =====");

string pagesText7 = "464";
int pages7 = Convert.ToInt32(pagesText7);

Console.WriteLine("Converted pages: " + pages7);


// =============================
// Q08 - Parse and TryParse
// =============================

Console.WriteLine("\n===== Q08 =====");

string yearText = "2023";
int year8 = int.Parse(yearText);

Console.WriteLine("Year: " + year8);

string badText = "abc";

if (int.TryParse(badText, out int result8))
{
    Console.WriteLine(result8);
}
else
{
    Console.WriteLine("Invalid number");
}


// =============================
// Q09 - ToString and GetType
// =============================

Console.WriteLine("\n===== Q09 =====");

int pages9 = 464;
string pagesText9 = pages9.ToString();

Console.WriteLine("Pages as string: " + pagesText9);
Console.WriteLine("Type: " + pagesText9.GetType());


// =============================
// Q10 - Boxing and Unboxing
// =============================

Console.WriteLine("\n===== Q10 =====");

int copies = 100;

object boxedCopies = copies;
int unboxedCopies = (int)boxedCopies;

Console.WriteLine("Boxed: " + boxedCopies);
Console.WriteLine("Unboxed: " + unboxedCopies);


// =============================
// Q11 - Nullable Integer
// =============================

Console.WriteLine("\n===== Q11 =====");

int? year11 = null;

Console.WriteLine("Has Value: " + year11.HasValue);

year11 = 2023;

Console.WriteLine("Year: " + year11.Value);


// =============================
// Q12 - Nullable String
// =============================

Console.WriteLine("\n===== Q12 =====");

string? reviewer = null;

Console.WriteLine("Is Null: " + (reviewer == null));


// =============================
// Q13 - Null Conditional Operator
// =============================

Console.WriteLine("\n===== Q13 =====");

Book? book13 = null;

string? title = book13?.Title;

Console.WriteLine("Title: " + title);


// =============================
// Q14 - Null Coalescing Operators
// =============================

Console.WriteLine("\n===== Q14 =====");

Console.WriteLine("Default Title: " + (title ?? "Untitled"));

title ??= "Untitled";

Console.WriteLine("Assigned Title: " + title);


// =============================
// Q15 - Null Forgiving Operator
// =============================

Console.WriteLine("\n===== Q15 =====");

string? name = "Ahmed";

string confirmedName = name!;

Console.WriteLine("Confirmed Name: " + confirmedName);


// =============================
// End of Assignment
// =============================

Console.WriteLine("\n===== ALL QUESTIONS COMPLETED =====");


// =============================
// Book Class
// =============================

public class Book
{
    public string Title { get; set; } = "";
    public int Pages { get; set; }
}
