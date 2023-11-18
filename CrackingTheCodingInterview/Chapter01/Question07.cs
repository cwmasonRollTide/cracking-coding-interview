using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Given an image represented by an NxN matrix, where each pixel
/// in the image is four bytes, write a method to rotate the image
/// by 90 degrees. Can you do this in place?
/// </summary>
public class Question07 : Question
{
    private static int[][] RotateImageByNinetyDegrees(List<int>[] input)
    {
        int n = input.Length;
        var result = new int[n][];

        for (var i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                result[j][n - i - 1] = input[i][j];
            }
        }

        return result;
    }

    public override object? Run(params object[] parameters)
    {
        if (parameters == null || parameters.Length == 0 || parameters.Any(p => p is not List<int>))
        {
            throw new ArgumentException("Invalid or missing parameters");
        }

        var input = new List<int>[parameters.Length];
        for (var i = 0; i < parameters.Length; i++)
        {
            input[i] = parameters[i] as List<int> ?? throw new InvalidOperationException();
        }

        return RotateImageByNinetyDegrees(input);
    }
}