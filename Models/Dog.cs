namespace CSharp_DayOne.Models;

public class Dog
{
  public Dog(string name, int age, string breed, int id)
  {
    Name = name;
    Age = age;
    Breed = breed;
    isGood = isGood;
    Id = id;
  }

  public string Name { get; set; }
  public int Age { get; set; }
  public string Breed { get; set; }
  public bool isGood { get; set; } = true;
  public int Id { get; set; }
}