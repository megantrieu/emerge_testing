namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using static MudBlazor.CategoryTypes;
using System;


public class SameZipTests
{
    [Fact]
    public void Test_SameZip()
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
        Assert.False(user.sameZip(null));
    }

    [Fact]
    public void Test_SameZip2()
    {
        List<String> affected = new List<String>();
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
        Assert.False(user.sameZip(affected));
    }
}