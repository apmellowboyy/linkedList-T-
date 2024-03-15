using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {

        string[] food =
            { "pizza", "tacos", "fries", "gummies", "lasagna", "spaghetti" };
        LinkedList<string> foodList = new LinkedList<string>(food);
        Console.WriteLine("Yet another food list");
        foreach (string Food in foodList)
        {
            Console.WriteLine(Food);
        }
        Console.WriteLine();

        foodList.AddLast("Hot Pockets");
        foodList.AddFirst("Ice Cream");


        LinkedListNode<string> targetLocation = foodList.Find("fries");
        Console.WriteLine("food after fries is {0}", targetLocation.Next.Value);
        Console.WriteLine();
        foodList.AddAfter(targetLocation, "Sub");
        foodList.AddBefore(targetLocation, "Lettuce");
        Console.WriteLine("Listed with ADDED items");
        foreach (string Food in foodList)
        {
            Console.WriteLine(Food);
        }
        Console.WriteLine();
        foodList.RemoveFirst();
        foodList.RemoveLast();
        Console.WriteLine("Listed with REMOVED items");
        foreach (string friend in foodList)
        {
            Console.WriteLine(friend);
        }
        Console.WriteLine();

        string[] foodArray = new string[foodList.Count];
        foodList.CopyTo(foodArray, 0);
        Console.WriteLine("foodList is now foodArray");
        foreach (string f in foodArray)
        {
            Console.WriteLine(f);
        }
        foodList.Clear();
        foodList.Count();

    }

}