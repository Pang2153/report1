using System;

class Program
{
    static string AaConvert(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
            else if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
        }

        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("텍스트를 입력하세요: ");
        string input = Console.ReadLine();
        string convertedText = AaConvert(input);

        Console.WriteLine("변환된 텍스트: " + convertedText);
    }
}