// code .\test\WebUI.IntegrationTest\IntegrationTestPages.cs
using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WebUI.IntegrationTest;

public class IntegrationTestPages : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public IntegrationTestPages(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("Index")]
    [InlineData("Privacy")]
    [InlineData("Index1")]
    [InlineData("Privacy1")]
    [InlineData("Index21")]
    [InlineData("Privacy21")]
    [InlineData("Index321")]
    [InlineData("Privacy321")]
    public async Task TestGetPages(string url)
    {
        // Arrange
        var client = _factory.CreateClient();

        // Act
        var response = await client.GetAsync(url);

        // Assert
        response.EnsureSuccessStatusCode();
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}