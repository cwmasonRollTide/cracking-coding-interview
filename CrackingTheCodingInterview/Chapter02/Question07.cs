using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

public class Question07 : Question
{
    private static Node<int>? FindIntersection(Node<int>? listOne, Node<int>? listTwo)
    {
        HashSet<Node<int>?> listOneContents = new HashSet<Node<int>?>();
        while (listOne != null)
        {
            listOneContents.Add(listOne);
            listOne = listOne.Next;
        }

        while (listTwo != null)
        {
            if (listOneContents.Contains(listTwo)) return listTwo;
            listTwo = listTwo.Next;
        }

        throw new Exception("No Intersection found");
    }
    public override object? Run(params object[] parameters)
    {
        var listOne = parameters[0] as Node<int>;
        var listTwo = parameters[1] as Node<int>;
        return FindIntersection(listOne!, listTwo!);
    }
}