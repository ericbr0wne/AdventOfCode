using System.Linq;
using System.Text.RegularExpressions;

static int firstDigit(int n)
{
    while (n >= 10)
        n /= 10;

    return n;
}
static int lastDigit(int n)
{
    return (n % 10);
}

static int concat(int a, int b)
{

    string s1 = a.ToString();
    string s2 = b.ToString();

    string s = s1 + s2;

    int c = int.Parse(s);

    return c;
}

//string[] inputlist = File.ReadAllLines("../../../input.txt");
string[] inputlist = File.ReadAllLines("../../../example.txt");

List<string> stringlist = new List<string>();

List<int> ints = new List<int>();


// Check conditions and output result based on string content
// Check if the length of the string is less than 6 and it's equal to "Hello"
// OR check if the string starts with "Hello" and the character at index 5 is a space (' ')

foreach (string line in inputlist)
{
    if (line.StartsWith("one") || line.StartsWith("two") || line.StartsWith("three") || line.StartsWith("four") || line.StartsWith("five") || 
        line.StartsWith("six") || line.StartsWith("seven") || line.StartsWith("eig") || line.StartsWith("nine"))
    {
        stringlist.Add(line.Replace("zero", "0").Replace("one", "1").Replace("t", "2").Replace("three", "3").Replace("four", "4")
    .Replace("five", "5").Replace("six", "6").Replace("seven", "7").Replace("eig", "8").Replace("nine", "9"));
       ;
    }
    else if (true)
    {
        stringlist.Add(line.Replace("zero", "0").Replace("one", "1").Replace("two", "2").Replace("three", "3").Replace("four", "4")
            .Replace("five", "5").Replace("six", "6").Replace("seven", "7").Replace("eight", "8").Replace("nine", "9"));
        
    }

}
foreach (string line in stringlist)
{
    Console.WriteLine(line);
}
Console.ReadKey();

foreach (string line in stringlist)
{
    string stripped = Regex.Replace(line, "[^0-9]", "");

    int.TryParse(stripped, out int numbers);
    {
        ints.Add(numbers);
    }
}

int total = 0;
foreach (int line in ints)
{
    Console.WriteLine(concat(firstDigit(line), lastDigit(line)));

    int sumLine = concat(firstDigit(line), lastDigit(line));

    total = total += sumLine;
}
Console.WriteLine(total);