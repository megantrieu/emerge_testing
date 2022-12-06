namespace emerge_testing;
using MudBlazor;
using emerge.Data;
using static MudBlazor.CategoryTypes;
using System;
using static MudBlazor.FilterOperator;


public class CheckUpdateTests
{
    [Fact]
    public void Test_CheckUpdate()
    {
        var payload = new UpdateInfo()
        {
            UpdateTime = System.DateTime.Now,
            UpdateDescription = "dfasdfa",
            UpdatePriority = 3
        };
        Assert.True(payload.CheckUpdate());
    }

    [Fact]
    public void Test_CheckUpdate2()
    {
        var payload = new UpdateInfo()
        {
            UpdateTime = System.DateTime.Now,
            UpdateDescription = null,
            UpdatePriority = 3
        };
        Assert.False(payload.CheckUpdate());
    }
}