namespace LinqExample.LinqMethods;

/// <summary>
/// Karışık object listeden sadece istenilen türü seçer.
/// </summary>
public class OfTypeExample
{
    public void GetStrings()
    {
        var stringResult = Repository.mixedList.OfType<string>();
    }
}
