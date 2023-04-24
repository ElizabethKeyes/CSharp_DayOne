namespace CSharp_DayOne.Services;
public class DogsService
{

  private readonly DogsRepository _repo;
  public DogsService(DogsRepository repo)
  {
    _repo = repo;
  }

  internal Dog Create(Dog dogData)
  {
    Dog dog = _repo.Create(dogData);
    return dog;
  }

  internal List<Dog> Get()
  {
    List<Dog> dogs = _repo.Get();
    return dogs;
  }

  internal Dog GetOne(int dogId)
  {
    Dog dog = _repo.GetOne(dogId);
    if (dog == null) throw new Exception($"no dog found at {dogId}");
    return dog;
  }
}