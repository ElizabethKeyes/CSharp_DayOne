namespace CSharp_DayOne.Repositories;

public class DogsRepository
{
  private readonly FakeDB _db;

  public DogsRepository(FakeDB db)
  {
    _db = db;
  }

  internal Dog Create(Dog dogData)
  {
    int dogId = _db.Dogs[_db.Dogs.Count - 1].Id + 1;
    Dog dog = new Dog(dogData.Name, dogData.Age, dogData.Breed, dogId);
    _db.Dogs.Add(dog);
    return dog;
  }

  internal List<Dog> Get()
  {
    return _db.Dogs;
  }

  internal Dog GetOne(int dogId)
  {
    Dog dog = _db.Dogs.Find(d => d.Id == dogId);
    return dog;
  }
}