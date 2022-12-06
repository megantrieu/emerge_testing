namespace emerge_testing;
using MudBlazor;
using emerge.Data;


public class LoopTests
{
    [Fact]
    public void LoopTest_GenerateZipString3()
    {
        List<String> affected = new List<String>();
        affected.Add("91770");
        affected.Add("91776");
        var payload = new NewsAlert()
        {
            Id = "3423Test",
            Time = DateTime.Now,
            Title = "Test1",
            Affected = affected,
            Author = "Megan Amber",
            Department = new Department(),
            Description = "blah blah",
            Priority = 3,
            ImageUrl = "image.url",
            Updates = new List<UpdateInfo>()
        };
        String call1 = payload.generateZipString();
        call1 += payload.generateZipString();
        Assert.Equal(call1, "91770, 9177691770, 91776");
    }

    [Fact]
    public void LoopTest_GenerateZipString4()
    {
        List<String> affected = new List<String>();
        affected.Add("91770");
        affected.Add("91776");
        var payload = new NewsAlert()
        {
            Id = "3423Test",
            Time = DateTime.Now,
            Title = "Test1",
            Affected = affected,
            Author = "Megan Amber",
            Department = new Department(),
            Description = "blah blah",
            Priority = 3,
            ImageUrl = "image.url",
            Updates = new List<UpdateInfo>()
        };
        String call1 = payload.generateZipString();
        call1 += payload.generateZipString();
        call1 += payload.generateZipString();
        Assert.Equal(call1, "91770, 9177691770, 9177691770, 91776");
    }
}