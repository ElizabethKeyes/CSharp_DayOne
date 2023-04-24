namespace CSharp_DayOne.Repositories;

public class DogsRepository
{
  private readonly FakeDB _db;

  public DogsRepository(FakeDB db)
  {
    _db = db;
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