namespace CrackingTheCodingInterview.Shared;

public abstract class Question
{
    public abstract object Run(params object[] parameters);
    public string Name => GetType().ToString();
}