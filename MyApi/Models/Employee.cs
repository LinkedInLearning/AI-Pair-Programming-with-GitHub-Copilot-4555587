namespace MyApi.Models;
public class Employee
{
  public Employee()
  {
    Name = "";
  }
  public int Id { get; set; }

  public string Name { get; set; }
  public int Age { get; set; }
  public int YearsOfService { get; set; }
}