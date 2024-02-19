


string ReversedName()
{

    Console.WriteLine("Write name: ");
    string name = Console.ReadLine();
    string CheckString (string name)
    {
        return name.Trim().ToLower();
    }
    string reversedText = "";


    for (int i = name.Length - 1; i >= 0; i--)
    {
        reversedText += name[i];
    }

return reversedText;

}
Console.WriteLine(ReversedName());