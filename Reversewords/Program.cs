// See https://aka.ms/new-console-template for more information

//reverse words
using System.Formats.Asn1;

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}
string input = "snake";
Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));


//reverse a sentence

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach(string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string input1 = "there are snakes at the zoo";
Console.WriteLine(input1);
Console.WriteLine(ReverseSentence(input1));

//method that returns a boolean
string[] words = { "racecar", "talanted", "deified", "tent", "tenet" , "malayalam"};

Console.WriteLine("is it a palindrome? ");
foreach(string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while(start < end)
    {
        if (word[start] != word[end])
            return false;
        start++;
        end--;
    }
    return true;
}

//find coins to make change

int[] TwoCoins(int[] coins, int target)
{
    for( int curr = 0; curr < coins.Length; curr++)
    {
        for(int next = curr +1; next <coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }
        }
    }

    return new int[0];
}

int target = 60;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
    Console.WriteLine("No tow coins make change");
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}


//multiple pairs of coins that make change
int[,] TwoCoins1(int[] coins1, int target1)
{
    int[,] result1 = { { -1, -1 }, { -1, -1 }, { -1, -1 } };
    int count = 0;

    for(int curr =0; curr < coins1.Length; curr++)
    {
        for(int next = curr +1; next <coins1.Length; next++)
        {
            if (coins1[curr] + coins1[next] == target1)
            {
                result1[count, 0] = curr;
                result1[count, 1] = next;
                count++;
            }
            if(count == result.GetLength(0))
            {
                return result1;
            }
        }
    }
    return (count == 0) ? new int[0, 0] : result1;
}

int target1=80;
int[] Coins1 = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result1 = TwoCoins1(Coins1, target1);

if (result1.Length == 0)
    Console.WriteLine("No tow coins make change");
else
{
    Console.WriteLine("Change found at positions:");
    for(int i=0; i<result1.GetLength(0); i++)
    {
        if (result1[i, 0] == -1)
            break;
        Console.WriteLine($"{result1[i, 0]},{result1[i, 1]}");
    }
}

