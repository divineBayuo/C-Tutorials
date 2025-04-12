// this code converts roman numeral to arabic
int RomanToInt(string s)
{
    // convert the roman numeral into array
    char[] charinword = new char[s.Length];
    charinword = s.ToArray();

    // create an array to keep converted characters
    int[] convnum = new int[s.Length];
    int num = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (charinword[i] == 'I')
        {
            num = 1;
        }
        else if (charinword[i] == 'V')
        {
            num = 5;
        }
        else if (charinword[i] == 'X')
        {
            num = 10;
        }
        else if (charinword[i] == 'L')
        {
            num = 50;
        }
        else if (charinword[i] == 'C')
        {
            num = 100;
        }
        else if (charinword[i] == 'D')
        {
            num = 500;
        }
        else if (charinword[i] == 'M')
        {
            num = 1000;
        }
        convnum[i] = num;
    }

    int sum = 0;
    for (int j = convnum.Length; j < 0; j--) {
        if (convnum[j] == convnum[j-1])
            sum = convnum[j] + convnum[j-1];
    }

    // convert the int array into an integer
    int ArrayToInt(int[] array) {
        string s = string.Join("", array.Select(n => n.ToString()));
        return int.Parse(s);
    }

    int finalnum = ArrayToInt(convnum);

    // return final value
    return finalnum;
}

Console.WriteLine(RomanToInt("VIII"));