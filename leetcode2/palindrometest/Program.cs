/* bool IsPalindrome(int x)
{
    // pull out last digit and first digit
    int lastDigit = x % 10;
    int digitlength = x.ToString().Length;
    double div = Math.Pow(10, (digitlength - 1));
    int firstDigit = x / (int)div;

    if (firstDigit == lastDigit)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] num = new int[3] { 121, -10, 808 };
for (int i = 0; i < 3; i++) { Console.WriteLine(IsPalindrome(num[i])); } */
// didn't work for -10

// new approach
// convert the number to string, save it in a different variable and reverse
// then compare the original with the reversal

bool IsPalindrome(int x) {
    string xinchar = x.ToString();
    string xincharrev = new string(x.ToString().Reverse().ToArray());

    if (xinchar == xincharrev)
        return true;
    else
        return false;
}

int[] num = new int[3] { 121, -10, 808 };
for (int i = 0; i < 3; i++) { Console.WriteLine(IsPalindrome(num[i])); }

