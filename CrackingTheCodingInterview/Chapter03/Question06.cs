using CrackingTheCodingInterview.Shared;

namespace CrackingTheCodingInterview.Chapter03;

public class Question06
{
    
}

public class AnimalShelter
{
    private LinkedListQueue<Cat?> _catQueue = new();
    private LinkedListQueue<Dog?> _dogQueue = new();

    public void Enqueue(Animal animalToAdd)
    {
        animalToAdd.EnqueuedAt = DateTime.UtcNow;
        if (animalToAdd.GetType() == typeof(Cat))
            _catQueue.Add(animalToAdd as Cat);
        else
            _dogQueue.Add(animalToAdd as Dog);
    }

    public Animal DequeueAny()
    {
        if (_catQueue.IsEmpty())
            return _dogQueue.Remove();
        if (_dogQueue.IsEmpty())
            return _catQueue.Remove();
        
        if (_catQueue.Peek().EnqueuedAt < _dogQueue.Peek().EnqueuedAt)
            return _catQueue.Remove();
        
        return _dogQueue.Remove();
    }

    public Cat DequeueCat()
    {
        return (_catQueue.Remove() as Cat)!;
    }
    
    public Dog DequeueDog()
    {
        return (_dogQueue.Remove() as Dog)!;
    }
}

public record Animal(string Name)
{
    public DateTime EnqueuedAt { get; set; }
}
public record Dog(string Name): Animal(Name);
public record Cat(string Name) : Animal(Name);
