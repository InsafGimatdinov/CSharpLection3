using System;
public class Example3
{
    public static void Main()
    {
        string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
                    + "ежели бы вас послали вместо нашего милого Винценгероде,"
                    + "вы бы взяли приступом согласие пруского короля. "
                    + "Вы так красноречивы. Вы дадите мне чаю?";
        // string s = "qwerty"
                    // 012345
        string Replace(string text, char oldValue, char newValue)
        {
            string result = String.Empty;
            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) 
                {
                    result = result + $"{newValue}";
                }
                else
                {
                    result = result + $"{text[i]}";
                }
            }
            return result;
        }
        string res = Replace(text: text, oldValue: ' ', newValue: '|');
        Console.WriteLine(res);
        Console.WriteLine();
        res = Replace(text: text, oldValue: 'к', newValue: 'К');
        Console.WriteLine(res);
    }
}