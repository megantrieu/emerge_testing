namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using emerge.Controller;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
using System.Xml.Linq;
using static MudBlazor.CategoryTypes;

public class AllAlertTests
{

    [Fact]
    public void Test_Following1()
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
        CurrentProfile.currentUser = user;
        NewsFeedController news = new NewsFeedController();
        Assert.NotEmpty(news.getFollowingList());
    }
    [Fact]
    public void Test_Following2()
    {
        var user = new UserProfile()
        {
            Name = "Tester",
            Username = "tester",
            Password = "1341",
            Email = "342",
            Zipcode = "917728",
            Admin = false,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        CurrentProfile.currentUser = user;
        NewsFeedController news = new NewsFeedController();
        Assert.NotEmpty(news.getFollowingList());
    }



}