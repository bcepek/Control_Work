string[] s = new string[] { "Text", "Tex", "-3", "Something", "I", "love", "typing" };
string[] newString = getShortStrings(s);
printStringArray(newString);

string[] getShortStrings(string[] s)
{
    int newStringLength = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3) newStringLength += 1;
    }
    string[] newString = new string[newStringLength];
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i].Length <= 3)
        {
            newString[count] = s[i];
            count += 1;
        }
    }
    return newString;
}

void printStringArray(string[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}