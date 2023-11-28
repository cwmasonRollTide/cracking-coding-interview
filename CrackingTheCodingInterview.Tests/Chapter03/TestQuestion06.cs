using CrackingTheCodingInterview.Chapter03;
using FluentAssertions;

namespace CrackingTheCodingInterview.Tests.Chapter03;

public class TestQuestion06
{
    [Fact]
    public void AnimalShelter_ShouldMaintain_Overall_And_Seperate_Queues()
    {
        const string catOneName = "CAT NUMBER ONE";
        const string catTwoName = "CAT NUMBER TWO";
        const string dogOneName = "DOG NUMBER ONE";
        const string dogTwoName = "DOG NUMBER TWO";
        const string catThreeName = "CAT NUMBER THREE";
        const string dogThreeName = "DOG NUMBER THREE";

        var catOne = new Cat(catOneName);
        var catTwo = new Cat(catTwoName);
        var dogOne = new Dog(dogOneName);
        var dogTwo = new Dog(dogTwoName);
        var catThree = new Cat(catThreeName);
        var dogThree = new Dog(dogThreeName);

        var animalShelter = new AnimalShelter();
        animalShelter.Enqueue(catOne);
        animalShelter.Enqueue(catTwo);
        animalShelter.Enqueue(dogOne);
        animalShelter.Enqueue(dogTwo);
        animalShelter.Enqueue(catThree);
        animalShelter.Enqueue(dogThree);
        
        animalShelter.DequeueAny().Name.Should().Be(catOneName);
        animalShelter.DequeueCat().Name.Should().Be(catTwoName);
        animalShelter.DequeueCat().Name.Should().Be(catThreeName);
        animalShelter.DequeueAny().Name.Should().Be(dogOneName);
        animalShelter.DequeueAny().Name.Should().Be(dogTwoName);
        animalShelter.DequeueAny().Name.Should().Be(dogThreeName);
    }
    
    [Fact]
    public void AnimalShelter_Should_DqueueDogs()
    {
        const string catOneName = "CAT NUMBER ONE";
        const string dogOneName = "DOG NUMBER ONE";
        const string catTwoName = "CAT NUMBER TWO"; 
        const string catThreeName = "CAT NUMBER THREE";
        const string dogTwoName = "DOG NUMBER TWO";
        const string dogThreeName = "DOG NUMBER THREE";

        var catOne = new Cat(catOneName);
        var catTwo = new Cat(catTwoName);
        var dogOne = new Dog(dogOneName);
        var dogTwo = new Dog(dogTwoName);
        var catThree = new Cat(catThreeName);
        var dogThree = new Dog(dogThreeName);

        var animalShelter = new AnimalShelter();
        animalShelter.Enqueue(catOne);
        animalShelter.Enqueue(dogOne);
        animalShelter.Enqueue(catTwo);
        animalShelter.Enqueue(catThree);
        animalShelter.Enqueue(dogTwo);
        animalShelter.Enqueue(dogThree);
        
        animalShelter.DequeueCat().Name.Should().Be(catOneName);
        animalShelter.DequeueCat().Name.Should().Be(catTwoName);
        animalShelter.DequeueDog().Name.Should().Be(dogOneName);
        animalShelter.DequeueDog().Name.Should().Be(dogTwoName);
        animalShelter.DequeueDog().Name.Should().Be(dogThreeName);
    }
}