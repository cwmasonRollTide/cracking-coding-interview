using CrackingTheCodingInterview.Chapter01;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter01;

public class TestQuestion08
{
    private static Question08 Sut => new();

    public static IEnumerable<object[]> MatrixRotationDataOne =>
        new List<object[]>
        {
            // Test Case 1
            new object[] 
            { 
                new List<int>[] 
                {
                    new() { 0, 2, 3 },
                    new() { 4, 5, 6 }, 
                    new() { 7, 8, 0 } 
                },
                new List<int>[]
                {
                    new() { 0, 0, 0 },
                    new() { 0, 5, 0 }, 
                    new() { 0, 0, 0 } 
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
                    new() { 0, 0, 0 }, 
                    new() { 9, 0, 2 }, 
                    new() { 7, 0, 7 }
                }
            }
        };

    [Theory]
    [MemberData(nameof(MatrixRotationDataOne))]
    public void ZeroOutColumnAndRowIfValueZero(List<int>[] input, List<int>[] expected)
    {
        var result = (int[][])Sut.Run(input);
        result.Should().BeEquivalentTo(expected);
    }
}