using CrackingTheCodingInterview.Chapter01;
using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        var chapters = new[]
        {
            // Chapter 01
            new Question[]
            {
                new Question01(),
                new Question02(),
                new Question03()
            }
        };
        
        for (var i=0; i<chapters.Length; i++)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("// ---- ---- ---- ");
            Console.WriteLine($"// Chapter: {i+1}");
            Console.WriteLine("// ---- ---- ---- \n");

            foreach (Question q in chapters[i])
            {
                Console.WriteLine("// ---- ---- ---- ");
                Console.WriteLine($"// Executing: {q.Name.Split(".").Last()}");
                Console.WriteLine("// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ----");
                q.Run();
            }
        }

        Console.WriteLine($"{Environment.NewLine}{Environment.NewLine}");
        Console.WriteLine("Press [Enter] to quit");
        Console.ReadLine();
    }
}
