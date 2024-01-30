namespace MyApi.Models;

/// <summary>
/// Employeeクラスは、従業員のデータを管理します。
/// これは、従業員の情報の取得、更新、削除などの操作を提供します。
/// </summary>
public class Employee
{
  public Employee()
  {
    Name = "";
  }

  /// <summary>
  /// Idプロパティは、従業員の一意の識別子を表します。
  /// </summary>
  public int Id { get; set; }

  /// <summary>
  /// Nameプロパティは、従業員の名前を表します。
  /// </summary>
  public string Name { get; set; }

  /// <summary>
  /// Ageプロパティは、従業員の年齢を表します。
  /// </summary>
  public int Age { get; set; }
  
  /// <summary>
  /// YearsOfServiceプロパティは、従業員が会社で働いている年数を表します。
  /// </summary>
  public int YearsOfService { get; set; }
}