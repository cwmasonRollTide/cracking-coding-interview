using FluentAssertions;
using CrackingTheCodingInterview.Chapter01;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion07
{
    private static Question07 Sut => new();

    public static IEnumerable<object[]> MatrixRotationDataOne =>
        new List<object[]>
        {
            // Test Case 1
            new object[] 
            { 
                new List<int>[] 
                {
                    new() { 1, 2, 3 }, //(0, 0), (0, 1), (0, 2) -> 
                    new() { 4, 5, 6 }, 
                    new() { 7, 8, 9 } //(i, j) -> (j, n - i - 1
                },
                new List<int>[]
                {
                    new() { 7, 4, 1 }, // (0, 2), (1, 2), (2, 2)
                    new() { 8, 5, 2 }, 
                    new() { 9, 6, 3 }
                }
            },
            // Test Case 2
            new object[] 
            { 
                new List<int>[] 
                { 
                    new() { 8, 0, 6 }, 
                    new() { 9, 1, 2 }, 
                    new() { 7, 4, 7 } 
                },
                new List<int>[]
                {
                    new() { 7, 9, 8 }, 
                    new() { 4, 1, 0 }, 
                    new() { 7, 2, 6 }
                }
            }
        };

    [Theory]
    [MemberData(nameof(MatrixRotationDataOne))]
    public void ReverseImage(List<int>[] input, List<int>[] expected)
    {
        var result = (int[][])Sut.Run(input);
        result.Should().BeEquivalentTo(expected);
    }
}