using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    /*
    static void Main(string[] args)
    {
        #region // 1. Alert Service
        IAlertDAO alertDAO = new AlertDAO();
        var a = new AlertService(alertDAO);
        #endregion

        #region // 2. Merge Names
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        #endregion

        #region // 3. Palindrome
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        #endregion

        #region // 4. Binary Search Tree
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(BinarySearchTree.Contains(n2, 3));
        #endregion

        #region // 5. Song
        Song first = new Song("Hey Jude");
        Song second = new Song("Eye of the tiger");
        Song third = new Song("Billie Jean");
        Song fourth = new Song("2 Become 1");
        Song fifth = new Song("Material Girl");

        first.NextSong = second;
        second.NextSong = third;
        third.NextSong = fourth;
        fourth.NextSong = fifth;
        fifth.NextSong = first;

        Console.WriteLine(first.IsRepeatingPlaylist());
        #endregion

        #region // 6. User Input
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
        #endregion

        #region // 8. Two Sum
        Tuple<int, int> indices = TwoSum.FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
        #endregion

        #region // 9. Account
        Console.WriteLine("Access.Writer.Delete :" + Account2.Access.Writer.HasFlag(Account2.Access.Delete));
        Console.WriteLine("Access.Writer.Publish :" + Account2.Access.Writer.HasFlag(Account2.Access.Publish));
        Console.WriteLine("Access.Writer.Submit :" + Account2.Access.Writer.HasFlag(Account2.Access.Submit));
        Console.WriteLine("Access.Writer.Comment :" + Account2.Access.Writer.HasFlag(Account2.Access.Comment));
        Console.WriteLine("Access.Writer.Modify :" + Account2.Access.Writer.HasFlag(Account2.Access.Modify));

        Console.WriteLine("Access.Editor.Delete :" + Account2.Access.Editor.HasFlag(Account2.Access.Delete));
        Console.WriteLine("Access.Editor.Publish :" + Account2.Access.Editor.HasFlag(Account2.Access.Publish));
        Console.WriteLine("Access.Editor.Submit :" + Account2.Access.Editor.HasFlag(Account2.Access.Submit));
        Console.WriteLine("Access.Editor.Comment :" + Account2.Access.Editor.HasFlag(Account2.Access.Comment));
        Console.WriteLine("Access.Editor.Modify :" + Account2.Access.Editor.HasFlag(Account2.Access.Modify));

        Console.WriteLine("Access.Owner.Delete :" + Account2.Access.Owner.HasFlag(Account2.Access.Delete));
        Console.WriteLine("Access.Owner.Publish :" + Account2.Access.Owner.HasFlag(Account2.Access.Publish));
        Console.WriteLine("Access.Owner.Submit :" + Account2.Access.Owner.HasFlag(Account2.Access.Submit));
        Console.WriteLine("Access.Owner.Comment :" + Account2.Access.Owner.HasFlag(Account2.Access.Comment));
        Console.WriteLine("Access.Owner.Modify :" + Account2.Access.Owner.HasFlag(Account2.Access.Modify));
        #endregion

        #region // 10. DecoratorStream
        byte[] message = new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f, 0x2c, 0x20, 0x77, 0x6f, 0x72, 0x6c, 0x64, 0x21 };
        using (MemoryStream stream = new MemoryStream())
        {
            using (DecoratorStream decoratorStream = new DecoratorStream(stream, "First line: "))
            {
                decoratorStream.Write(message, 0, message.Length);
                decoratorStream.Write(message, 0, message.Length);
                stream.Position = 0;
                Console.WriteLine(new StreamReader(stream).ReadLine());  //should print "First line: Hello, world!"
            }
        }
        #endregion

        #region // 11. Folders
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
        #endregion

        #region // 12. Sorted Search
        Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4));
        #endregion

    } */

}

