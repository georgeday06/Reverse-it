using System.Data;

Start();

static void Start()
{
    Console.WriteLine("Enter the text to be reversed");
    string response = Console.ReadLine();

    if (response.Length == 0)
    {
        Console.WriteLine("A value must be entered. ");
        Start();
    }
    else
    {
        Reverse(response);
    }

}

static void Reverse(string response)
{
    Console.Clear();
    for (int i = 1; i <= response.Length; i++)
    {
        char temp = response[response.Length - i];
        Console.WriteLine(temp);
    }
    Console.WriteLine();
    checkLetters(response);
}

static void checkLetters(string response)
{
    int vowels = 0;
    int consonants = 0;
    char letter = ' ';
    for (int i = 1; i <= response.Length; i++)
    {
        char temp = response[response.Length - i];
        if (temp == 'A' || temp == 'E' || temp == 'I' || temp == 'O' || temp == 'U' || temp == 'a' || temp == 'e' || temp == 'i' || temp == 'o' || temp == 'u')
        {
            vowels++;
        }
        else
        {
            consonants++;
        }
    }
    Console.WriteLine("There are {0} vowles and {1} consonants.", vowels, consonants);
    checkPalindrome(response);
}

static void checkPalindrome(string response)
{
    char Original = ' ';
    char Reversed = ' ';
    int Count = 0;
    for (int i = 0; i < response.Length; i++)
    {
        for (int x = 1; x < response.Length; x++)
        {
            Original = response[i];
            Reversed = response[response.Length - x];

            if (Original == Reversed)
            {
                Count++;
            }
        }
    }
    if (Count == response.Length)
    {
        Console.WriteLine("{0} is a palindrome", response);
    }
}

