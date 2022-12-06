namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using static MudBlazor.CategoryTypes;
using System;
using static MudBlazor.FilterOperator;


public class CheckUserProfileTests
{
    [Fact]
    public void Test_CheckUp()
    {
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
        Assert.True(user.CheckUserProfile());
    }

    [Fact]
    public void Test_CheckUp2()
    {
        var user = new UserProfile()
        {
            Name = "Megan Amber",
            Username = "meganamber",
            Password = "123",
            Email = null,
            Zipcode = "91770",
            Admin = true,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        Assert.False(user.CheckUserProfile());
    }
}