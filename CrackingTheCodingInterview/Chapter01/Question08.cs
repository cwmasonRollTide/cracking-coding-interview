using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter01;

/// <summary>
/// Write an algorithm such that if an element in an MxN matrix is zero, its entire row and column are set to zero
/// </summary>
public class Question08 : Question
{
    private static int[][] ZeroOut(List<int>[] input)
    {
        int m = input.Length;
        int n = input[0].Count;
        var row = new bool[m];
        var column = new bool[n];
        var result = new int[m][];
        // Build the result and if there is a zero value,
        // set the row and column corresponding to true
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (var j = 0; j < n; j++)
            {
                result[i][j] = input[i][j];
                if (result[i][j] != 0) continue;
                
                row[i] = true;
                column[j] = true;
            }
        }
        
        // Iterate through the row boolean array and ZeroOutRow if there is a zero
        for (var i = 0; i < row.Length; i++)
        {
            if (row[i]) ZeroOutRow(result, i);
        }
        
        // Iterate through the column array and zero out if there is a zero
        for (var j = 0; j < column.Length; j++)
        {
            if (column[j]) ZeroOutColumn(result, j);
        }

        return result;
    }

    private static void ZeroOutRow(int[][] input, int row)
    {
        for (int j = 0; j < input[0].Length; j++)
        {
            input[row][j] = 0;
        }
    }

    private static void ZeroOutColumn(int[][] input, int column)
    {
        for (var i = 0; i < input.Length; i++)
        {
            input[i][column] = 0;
        }
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

        return ZeroOut(input);
    }
}