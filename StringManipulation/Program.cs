public class OutputString
{
    public string ModifyString(string inputString)
    {
        string[] words = inputString.Split(' ');
        return words[4] + " " + words[2] + " " + words[0].ToLower();
    }

    public static void Main()
    {
        var modify = new OutputString();
        string result = modify.ModifyString("Yash is a javascript ninja");
        Console.WriteLine(result);

    }
}

