using System;
using System.Text;
class GenerateRandomString
{
    static void Main()
    {
        int length = 2;

        // creating a StringBuilder object()
        StringBuilder str_build = new StringBuilder();
        Random random = new Random();

        char letter;


        for (int i = 0; i < length; i++)
        {
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            letter = Convert.ToChar(shift + 65);

            str_build.Append(letter);
        }
        double numberPass = random.NextDouble();
        string especialChars = "@#$&*()-_+=";
        string RandonPass = str_build.ToString() + Convert.ToInt32(Math.Floor(25 * numberPass)) + especialChars.Substring(random.Next(0, especialChars.Length - 1), 2);

        string encodedStr = Convert.ToBase64String(Encoding.UTF8.GetBytes(RandonPass));
        Console.WriteLine(RandonPass);
        Console.WriteLine(encodedStr);
    }
}