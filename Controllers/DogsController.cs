namespace CSharp_DayOne.Controllers;

[ApiController]
[Route("api/dogs")]

public class DogsController : ControllerBase
{
  private readonly DogsService _dogsService;
  public DogsController(DogsService dogsService)
  {
    _dogsService = dogsService;
  }

  [HttpGet]
  public ActionResult<List<Dog>> Get()
  {
    try
    {
      List<Dog> dogs = _dogsService.Get();
      return Ok(dogs);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}