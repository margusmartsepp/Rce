using System;
using Microsoft.Data.Entity;
using Rce.WebApi.Controllers;
using Xunit;

namespace Rce.WebApi.IntegrationTests.Controllers
{
    //public class RceControllerTests : IDisposable
    //{
    //    private readonly RceController _rceController;
    //    private readonly RceDbContext _rceDbContext;

    //    public RceControllerTests()
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<RceDbContext>();
    //        optionsBuilder.UseInMemoryDatabase();

    //        _rceDbContext = new RceDbContext(optionsBuilder.Options);
    //        _rceController = new RceController(_rceDbContext);
    //    }

    //    public void Dispose()
    //    {
    //        _rceDbContext.Database.EnsureDeleted();
    //    }

    //    [Theory]
    //    [InlineData(0, "value: 0")]
    //    [InlineData(1, "value: 1")]
    //    [InlineData(-1, "value: -1")]
    //    [InlineData(int.MaxValue, "value: 2147483647")]
    //    [InlineData(int.MinValue, "value: -2147483648")]
    //    public void Get_Returns_Expected_Message(int testValue, string expectedResult)
    //    {
    //        // Act
    //        var result = _rceController.Get(testValue);

    //        // Assert
    //        Assert.Equal(result, expectedResult);
    //    }
    //}
}
