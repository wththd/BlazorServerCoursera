namespace BlazorServerCoursera.Data;

public class MyCustomDataService
{
    public CustomData GetDataAsync()
    {
        return new CustomData()
        {
            Name = "Test",
            True = true,
            Number = 123
        };
    }
}