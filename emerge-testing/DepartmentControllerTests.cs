namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using emerge.Controller;
using Microsoft.Extensions.Options;
using System.Reflection.Emit;
using System.Xml.Linq;
using static MudBlazor.CategoryTypes;

public class DepartmentControllerTests
{

    [Fact]
    public void Test_GetDepts1()
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
        DepartmentController dpts = new DepartmentController();
        Assert.NotEmpty(dpts.getDeptList());
    }

    [Fact]
    public void Test_GetDepts2()
    {
        var user = new UserProfile()
        {
            Name = "HSHU",
            Username = "hsu",
            Password = "1i21",
            Email = "341",
            Zipcode = "31",
            Admin = false,
            Alerts = new List<NewsAlert>(),
            Following = new List<Department>()
        };
        CurrentProfile.currentUser = user;
        DepartmentController dpts = new DepartmentController();
        Assert.NotEmpty(dpts.getDeptList());
    }

}