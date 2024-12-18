using FluentAssertions;
using PracticeProject.Core.DTO.ProductDTOs;
using System.Net.Http.Json;
using System.Text.Json;
using Xunit.Abstractions;

namespace PracticeProject.IntegrationTests
{
    public class ProductsControllerIntegrationTests(CustomWebApplicationFactory factory, ITestOutputHelper outputHelper) : IClassFixture<CustomWebApplicationFactory>
    {
        private readonly HttpClient _httpClient = factory.CreateClient();
        private readonly ITestOutputHelper _outputHelper = outputHelper;

        [Fact]
        public async Task GetProducts_ToReturnAllProducts()
        {
            //act
            HttpResponseMessage response = await _httpClient.GetAsync("/api/v1/Products");

            //assert
            response.Should().BeSuccessful();
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);

            _outputHelper.WriteLine($"Status Code: {response.StatusCode}");


            var products = await response.Content.ReadFromJsonAsync<List<ProductResponse>>();

            _outputHelper.WriteLine($"Products: {JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true })}");

            products.Should().NotBeNull();
            products.Should().NotBeEmpty();

            products.Should().AllSatisfy(p =>
            {
                p.Id.Should().NotBe(Guid.Empty);
                p.Name.Should().NotBeNullOrWhiteSpace();
                p.Category.Should().NotBeNullOrWhiteSpace();
                p.Price.Should().BeGreaterThan(0m);
            });
        }
    }
}