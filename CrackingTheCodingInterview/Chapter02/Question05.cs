using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter02;

public class Question05 : Question
{
    private static Node<int> SumLists(Node<int> operandOne, Node<int> operandTwo)
    {
        string numberOne = ExtractReversedNumber(operandOne);
        string numberTwo = ExtractReversedNumber(operandTwo);
        var result = (int.Parse(numberOne) + int.Parse(numberTwo)).ToString();
        Node<int>? toReturn = null;
        for (var i = result.Length - 1; i >= 0; i--)
        {
            int number = result[i] - '0';
            if (toReturn == null) toReturn = new Node<int>(number);
            else toReturn.Append(number);
        }

        return toReturn;
    }

    private static string ExtractReversedNumber(Node<int> node)
    {
        if (node.Next == null)
        {
            return node.Data.ToString();
        }

        return ExtractReversedNumber(node.Next) + node.Data;
    }

    public override object? Run(params object[] parameters)
    {
        var operandOne = parameters[0] as Node<int>;
        var operandTwo = parameters[1] as Node<int>;
        return SumLists(operandOne!, operandTwo!);
    }
}