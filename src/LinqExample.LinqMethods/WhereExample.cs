namespace LinqExample.LinqMethods;

/// <summary>
/// Filtrelemek için kullanılır.
/// </summary>
public class WhereExample
{
    public bool IsTeenAger(Student stud)
    {
        return stud.Age > 12 && stud.Age < 20;
    }
}
