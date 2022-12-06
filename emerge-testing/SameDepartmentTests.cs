namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using static MudBlazor.CategoryTypes;
using System;


public class SameDepartmentTests
{
    [Fact]
    public void Test_SameDpt()
    {
        List<String> affected = new List<String>();
        affected.Add("91770");
        affected.Add("91776");
        var user = new UserProfile()
        {
            Name = "Megan Amber",
            Username = "meganamber",
            Password = "123",
            Email = "testemail",
            Zipcode = "91770",
            Admin = true,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        Assert.False(user.sameDepartment(null));
    }

    [Fact]
    public void Test_SameDpt2()
    {
        List<Department> Following = new List<Department>();
        var payload = new Department()
        {
            Id = "41341",
            Title = "fjakdfja",
            Description = "defasdfasdf",
            ImageUrl = "image.url",
            AlertList = new List<NewsAlert>()
        };

        Following.Add(payload);
        var user = new UserProfile()
        {
            Name = "Megan Amber",
            Username = "meganamber",
            Password = "123",
            Email = "testemail",
            Zipcode = "91770",
            Admin = true,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        Assert.False(user.sameDepartment(payload));
    }
}