using System.Text.RegularExpressions;

namespace Consonant;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a word : ");
        string word = Console.ReadLine();
        string regexId = @"[^aeiouAEIOU]{2}";
        bool check;

        Regex regex = new Regex(regexId);
        
        if(regex.IsMatch(word))
            check = true;

        else
            check = false;

        Console.WriteLine("");
        Console.WriteLine("Result : " + check);
    }
}
