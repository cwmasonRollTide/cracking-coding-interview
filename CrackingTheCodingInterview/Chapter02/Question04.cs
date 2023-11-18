using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

/// <summary>
/// Write code to partition a linked list around a value x, such that all nodes
/// less than x come before all nodes great than or equal to x. If x is contained
/// within the list, the values of x only need to be after the elements less than x.
/// The partition element x can appear anywhere in the right partition, it does not
/// need to appear between the left and right partitions
/// </summary>
public class Question04 : Question
{
    private static Node<int> PartitionList(Node<int>? head, int partitionValue)
    {
        Node<int>? lessThanHead = null;
        Node<int>? lessThanIterator = null;
        Node<int>? greatOrEqualToHead = null;
        Node<int>? iterator = head;
        while (iterator != null)
        {
            if (iterator.Data < partitionValue)
            {
                if (lessThanHead == null)
                {
                    lessThanHead = new Node<int>(iterator.Data);
                    lessThanIterator = lessThanHead;
                }
                else
                {
                    lessThanHead.Append(iterator.Data);
                    lessThanIterator = lessThanIterator!.Next;
                }
            }
            else
            {
                if (greatOrEqualToHead == null) greatOrEqualToHead = new Node<int>(iterator.Data);
                else greatOrEqualToHead.Append(iterator.Data);
            }
            iterator = iterator.Next;
        }

        lessThanIterator!.Next = greatOrEqualToHead;
        return lessThanHead!;
    }

    public override object? Run(params object[] parameters)
    {
        var head = parameters[0] as Node<int>;
        int partition = parameters[1] as int? ?? 0;
        return PartitionList(head, partition);
    }
}