using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        //throw new NotImplementedException("Waiting to be implemented.");
        string reverseWord = new string(word.ToUpper().Reverse().ToArray());

        return reverseWord.Equals(word.ToUpper()) ? true : false;
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    //}
}