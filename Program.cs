using AdventOfCodeDay1;
using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] inputlist = File.ReadAllLines("../../../input.txt");

int firstNr;
int lastNr;
int total = 0;

List<int> ints = new List<int>();

foreach (string line in inputlist)
{
    string stripped = Regex.Replace(line, "[^0-9]", "");
    int.TryParse(stripped, out int numbers);
    {
        ints.Add(numbers);
    }
}

foreach (int line in ints)
{
    Console.WriteLine(Concat.concat(FirstDigit.firstDigit(line), LastDigit.lastDigit(line)));

    int sumLine = Concat.concat(FirstDigit.firstDigit(line), LastDigit.lastDigit(line));

    total = total += sumLine;
}
Console.WriteLine(total);

/*
// string output = string.Concat(line.Where(Char.IsDigit));
// Find the first digit 
static int firstDigit(int n)
{
    // Remove last digit from number 
    // till only one digit is left 
    while (n >= 10)
        n /= 10;

    // return the first digit 
    return n;
}

// Find the last digit 
static int lastDigit(int n)
{
    // return the last digit 
    return (n % 10);
}
    

foreach (string input in inputlist)
{
    string stripped = Regex.Replace(input, "[^0-9]", "");

    //string[] split = stripped.Split();

    var lastItem = stripped[^1];
    var firstItem = stripped[0];

    foreach (int test in stripped)
    {

    total = firstItem + lastItem;
    Console.WriteLine(total);

    }
}
/*
    if (int.TryParse(stripped, out int numbers))
    {
        Console.WriteLine(numbers);
        if (numbers > 0) 
        {
            
        }
    }

            List<int> firstNrList = new List<int>(numbers);
            foreach (int lines in firstNrList)
foreach (string line in inputlist)
{
    string stripped = Regex.Replace(line, "[^0-9]", "");

    if (int.TryParse(stripped, out total))
    {
        Console.WriteLine(firstDigit(total));
    }
}

*/



//lastNr = test2.Last();
//total = firstNr = +lastNr;
//remove all non digits

/*if (only one number in string)
{
    firstNr = +firstNr;
}
else
{
    firstNr = +lastNr;
}

total = 
*/

/*
foreach (string line2 in test)
{
    int x = 0;
        firstNr = line2.First();
        Console.WriteLine(firstNr);

    if (Int32.TryParse(line2, out x))
    {
        //Console.WriteLine(x);
    }
}
*/


//use first and last


/*
try
{
    int numVal = Int32.Parse(line);
    Console.WriteLine(numVal);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
}

{

   

}

Console.WriteLine(line);
}

*/



//stripped = Regex.Replace(line, "[^0-9]", "");
//Console.WriteLine(stripped);
/*
MatchCollection matches = Regex.Matches(line, @"\d+(\.\d+)?");
List<string> numbers = new List<string>();
foreach (Match m in matches)
{
    numbers.Add(m.Value);
}
*/