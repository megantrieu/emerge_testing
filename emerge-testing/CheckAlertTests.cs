namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using System;


public class CheckAlertTests
{
    [Fact]
    public void Test_Dpts1()
    {
        List<String> affected = new List<String>();
        affected.Add("91770");
        var payload = new NewsAlert()
        {
            Id = "3423Test",
            Time = System.DateTime.Now,
            Title = "Test1",
            Affected = affected,
            Author = "Megan Amber",
            Department = new Department(),
            Description = "blah blah",
            Priority = 3,
            ImageUrl = "image.url",
            Updates = new List<UpdateInfo>()
        };
        Assert.True(payload.CheckAlert());
    }

    [Fact]
    public void Test_Alerts2()
    {
        List<String> affected = new List<String>();
        affected.Add("91770");
        var payload = new NewsAlert()
        {
            Id = "3423Test",
            Time = System.DateTime.Now,
            Title = null,
            Affected = affected,
            Author = "Megan Amber",
            Department = new Department(),
            Description = "blah blah",
            Priority = 3,
            ImageUrl = "image.url",
            Updates = new List<UpdateInfo>()
        };
        Assert.False(payload.CheckAlert());
    }
}