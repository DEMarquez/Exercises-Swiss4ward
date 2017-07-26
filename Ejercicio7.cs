using System;
using System.Collections.Generic;
using System.Linq;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
    public static IEnumerable<int> InOrder(Node root)
    {
        if (root == null)
        {
            yield break;
        }

        foreach (var n in InOrder(root.Left))
        {
            yield return n;
        }

        yield return root.Value;

        foreach (var n in InOrder(root.Right))
        {
            yield return n;
        }
    }

    public static bool IsValidBST(Node root)
    {
        var nodes = InOrder(root);
        var expected = nodes.OrderBy(x => x);
        return nodes.SequenceEqual(expected);
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

        Console.WriteLine(IsValidBST(n2));
        Console.ReadLine();
    }
}
