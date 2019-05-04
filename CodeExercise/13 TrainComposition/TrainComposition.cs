using System;

/*
A TrainComposition is built by attaching and detaching wagons from the left and the right sides, efficiently with respect to time used.

For example, if we start by attaching wagon 7 from the left followed by attaching wagon 13, again from the left, we get a composition of two wagons (13 and 7 from left to right). 
Now the first wagon that can be detached from the right is 7 and the first that can be detached from the left is 13.

Implement a TrainComposition that models this problem.

Two train carriages.
*/

public class TrainComposition
{
    public void AttachWagonFromLeft(int wagonId)
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public void AttachWagonFromRight(int wagonId)
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public int DetachWagonFromLeft()
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public int DetachWagonFromRight()
    {
        throw new NotImplementedException("Waiting to be implemented.");
    }

    public static void Main(string[] args)
    {
        TrainComposition tree = new TrainComposition();
        tree.AttachWagonFromLeft(7);
        tree.AttachWagonFromLeft(13);
        Console.WriteLine(tree.DetachWagonFromRight()); // 7 
        Console.WriteLine(tree.DetachWagonFromLeft()); // 13
    }
}