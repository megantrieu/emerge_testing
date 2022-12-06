namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using emerge.Controller;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
using System.Xml.Linq;
using static MudBlazor.CategoryTypes;

public class FollowingAlertTests
{

    [Fact]
    public void Test_AllAlerts1()
    {
        var user = new UserProfile()
        {
            Name = "TestingAll",
            Username = "TestingAll",
            Password = "123",
            Email = "testemail.com",
            Zipcode = "917723",
            Admin = true,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        CurrentProfile.currentUser = user;
        NewsFeedController news = new NewsFeedController();
        Assert.NotEmpty(news.getAlertList());
    }
    [Fact]
    public void Test_AllAlerts2()
    {
        var user = new UserProfile()
        {
            Name = "Megan Amber",
            Username = "meganamber",
            Password = "123",
            Email = "testemail",
            Zipcode = "917728",
            Admin = true,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        CurrentProfile.currentUser = user;
        NewsFeedController news = new NewsFeedController();
        Assert.NotEmpty(news.getAlertList());
    }



}