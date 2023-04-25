namespace CSharp_DayOne.Repositories;

public class FakeDB
{
  public List<Dog> Dogs;

  public FakeDB()
  {
    Dogs = new List<Dog>();
    Dogs.Add(new Dog("Sparky", 10, "Mutt", true, 1));
    Dogs.Add(new Dog("Spot", 5, "Poodle", true, 2));
    Dogs.Add(new Dog("Clifford", 7, "Big Red", true, 3));
  }
}