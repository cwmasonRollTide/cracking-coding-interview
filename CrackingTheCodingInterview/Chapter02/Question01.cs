using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

public class Question01 : Question
{
    private static Node<int> RemoveDuplicates(Node<int> head)
    {
        var collectedData = new HashSet<int> { head.Data };
        Node<int>? iterator = head.Next;
        
        while (iterator != null)
        {
            if (collectedData.Contains(iterator.Data))
            {
                head.Delete(iterator.Data);
            }
            else
            {
                collectedData.Add(iterator.Data);
            }
            iterator = iterator.Next;
        }

        return head;
    }
    public override object Run(params object[] parameters)
    {
        var input = parameters[0] as Node<int>;
        return RemoveDuplicates(input!);
    }
}