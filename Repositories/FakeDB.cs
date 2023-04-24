namespace CSharp_DayOne.Repositories;

public class FakeDB
{
  public List<Dog> Dogs;

  public FakeDB()
  {
    Dogs = new List<Dog>();
    Dogs.Add(new Dog("Sparky", 10, "Mutt", 1));
    Dogs.Add(new Dog("Spot", 5, "Poodle", 2));
    Dogs.Add(new Dog("Clifford", 7, "Big Red", 3));
  }
}