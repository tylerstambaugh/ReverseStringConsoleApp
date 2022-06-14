
string inputString = "gorgonzola";

Console.WriteLine(ReverseString.Reverse(inputString));

Console.ReadLine();

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string returnString = "";
        Console.WriteLine($"input length {input.Length}");

        for(int i = input.Length -1; i > -1; i--)
        {
            Console.WriteLine($"i = {i}");
            returnString = returnString + input[i];
            Console.WriteLine(returnString);
        }

        return returnString;
    }
}