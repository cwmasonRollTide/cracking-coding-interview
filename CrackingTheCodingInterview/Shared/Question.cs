namespace CrackingTheCodingInterview.Shared;

public abstract class Question
{
    public abstract void Run();
    public string Name => GetType().ToString();
}