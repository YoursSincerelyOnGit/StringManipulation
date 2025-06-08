public class OutputString
{
    public string ModifyString(string inputString)
    {
        string[] words = inputString.Split(' '); // breaks the string sentence in to an array of words
        return words[4] + " " + words[2] + " " + words[0].ToLower(); // returns the conjoined 5th word, 3rd word and 1st word (in lower case)
    }

    public static void Main()
    {
        var modify = new OutputString(); //creates an instance of the OutputString class
        string result = modify.ModifyString("Yash is a javascript ninja"); // calls the ModifyString method with a sample string
        Console.WriteLine(result); // displays the result on console

    }
}

