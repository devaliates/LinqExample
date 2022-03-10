namespace LinqExample.LinqMethods;

/// <summary>
/// İstenilen değere göre liste elemanlarını sıralar yeni liste verir.
/// </summary>
public class OrderByExample
{
    public void OgrenciIsimlerineGoreSirala()
    {
        var studentsInAscOrder = Repository.studentList.OrderBy(s => s.StudentName);
    }

    public void TersOgrenciIsimlerineGoreSirala()
    {
        var studentsInAscOrder = Repository.studentList.OrderByDescending(s => s.StudentName);
    }
}
