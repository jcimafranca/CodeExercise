using System;

/*
Each account on a website has a set of access flags that represent a users access.

Update and extend the enum so that it contains three new access flags:

A Writer access flag that is made up of the Submit and Modify flags.
An Editor access flag that is made up of the Delete, Publish and Comment flags.
An Owner access that is made up of the Writer and Editor flags.
For example, the code below should print "False" as the Writer flag does not contain the Delete flag.

Console.WriteLine(Access.Writer.HasFlag(Access.Delete))
 */

public class Account2
{
    [Flags]
    public enum Access
    {
        Writer = 1,
        Editor = 2,
        Owner = 1|2,

        Delete = 2,
        Publish = 2,
        Submit = 1,
        Comment = 2,
        Modify = 1
    }

    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("Access.Writer.Delete :" + Access.Writer.HasFlag(Access.Delete));
    //    Console.WriteLine("Access.Writer.Publish :" + Access.Writer.HasFlag(Access.Publish));
    //    Console.WriteLine("Access.Writer.Submit :" + Access.Writer.HasFlag(Access.Submit));
    //    Console.WriteLine("Access.Writer.Comment :" + Access.Writer.HasFlag(Access.Comment));
    //    Console.WriteLine("Access.Writer.Modify :" + Access.Writer.HasFlag(Access.Modify));

    //    Console.WriteLine("Access.Editor.Delete :" + Access.Editor.HasFlag(Access.Delete));
    //    Console.WriteLine("Access.Editor.Publish :" + Access.Editor.HasFlag(Access.Publish));
    //    Console.WriteLine("Access.Editor.Submit :" + Access.Editor.HasFlag(Access.Submit));
    //    Console.WriteLine("Access.Editor.Comment :" + Access.Editor.HasFlag(Access.Comment));
    //    Console.WriteLine("Access.Editor.Modify :" + Access.Editor.HasFlag(Access.Modify));

    //    Console.WriteLine("Access.Owner.Delete :" + Access.Owner.HasFlag(Access.Delete));
    //    Console.WriteLine("Access.Owner.Publish :" + Access.Owner.HasFlag(Access.Publish));
    //    Console.WriteLine("Access.Owner.Submit :" + Access.Owner.HasFlag(Access.Submit));
    //    Console.WriteLine("Access.Owner.Comment :" + Access.Owner.HasFlag(Access.Comment));
    //    Console.WriteLine("Access.Owner.Modify :" + Access.Owner.HasFlag(Access.Modify));

    //    //Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); // Should print: "False"
    //}
}