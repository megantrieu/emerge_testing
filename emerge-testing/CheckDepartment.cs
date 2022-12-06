namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using static MudBlazor.CategoryTypes;
using System;
using static MudBlazor.FilterOperator;


public class CheckDepartment
{
    [Fact]
    public void Test_Dpts1()
    {
        var payload = new Department()
        {
            Id = "41341",
            Title = "fjakdfja",
            Description = "defasdfasdf",
            ImageUrl = "image.url",
            AlertList = new List<NewsAlert>()
        };
        Assert.True(payload.CheckDepartment());
    }

    [Fact]
    public void Test_Dpts2()
    {
        var payload = new Department()
        {
            Id = "41341",
            Title = null,
            Description = "defasdfasdf",
            ImageUrl = "image.url",
            AlertList = new List<NewsAlert>()
        };
        Assert.False(payload.CheckDepartment());
    }
}