/*
    This snippet of code changes a string into an array of
    characters, rerverses the order of the array of
    characters, then counts the number of o's in the string.
    The results of the reverse and count are printed.
*/

string orginalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = orginalMessage.ToCharArray();
Array.Reverse(message);

int count = 0;

foreach (char letter in message) 
{ 
    if (letter == 'o') 
    { 
        count++; 
    } 
}

string reversedMessage = new String(message);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {count} times.");