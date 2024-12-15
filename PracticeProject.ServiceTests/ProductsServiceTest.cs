using AutoFixture;
using FluentAssertions;
using Moq;
using PracticeProject.Core.Domain.Entities;
using PracticeProject.Core.Domain.RepositoryContracts;
using PracticeProject.Core.DTO.ProductDTOs;
using PracticeProject.Core.Helpers;
using PracticeProject.Core.ServiceContracts;
using PracticeProject.Core.Services;
using Xunit.Abstractions;

namespace PracticeProject.ServiceTests;

public class ProductsServiceTest
{
    private readonly Mock<IProductsRepository> _productRepositoryMock;
    private readonly IProductsRepository _productsRepository;

    private readonly IProductsService _productsService;

    private readonly ITestOutputHelper _testOutputHelper;
    private readonly IFixture _fixture;

    public ProductsServiceTest(ITestOutputHelper testOutputHelper)
    {
        _fixture = new Fixture();

        _productRepositoryMock = new Mock<IProductsRepository>();
        _productsRepository = _productRepositoryMock.Object;

        _productsService = new ProductsService(_productsRepository);

        _testOutputHelper = testOutputHelper;
    }

    #region AddProduct
    [Fact]
    public async Task AddProduct_ValidProduct_ToBeSuccessful()
    {
        //Arrange
        ProductAddRequest productAddRequest = _fixture.Build<ProductAddRequest>().Create();
        Product product = productAddRequest.ToProduct();
        ProductResponse expectedProductResponse = product.ToProductResponse();

        _productRepositoryMock.Setup(p => p.AddProduct(It.IsAny<Product>())).ReturnsAsync((Product p) =>
        {
            p.Id = Guid.NewGuid();
            return p;
        });

        //Act
        ProductResponse actualProductResponse = await _productsService.AddProduct(productAddRequest);
        expectedProductResponse.Id = actualProductResponse.Id;

        //Assert
        actualProductResponse.Id.Should().NotBe(Guid.Empty);
        actualProductResponse.Should().Be(expectedProductResponse);
    }

    [Fact]
    public async Task AddProduct_NullRequest_ThrowsArgumentNullException()
    {
        // Arrange & Act
        Func<Task> act = async () => await _productsService.AddProduct(null);

        // Assert
        await act.Should().ThrowAsync<ArgumentNullException>();
    }

    #endregion

    #region RemoveProduct

    [Fact]
    public async Task RemoveProduct_ValidGuid_ToBeSuccessful()
    {
        //Arrange
        var product = _fixture.Build<Product>().With(temp => temp.Id, Guid.NewGuid()).Create();

        _productRepositoryMock
            .Setup(temp => temp.DeleteProductByProductID(It.IsAny<Guid>()))
            .ReturnsAsync(true);

        //Act
        var isDeleted = await _productsService.DeleteProductByID(product.Id);

        //Assert
        isDeleted.Should().BeTrue();
    }

    [Fact]
    public async Task RemoveProduct_NullGuid_ToThrowArgumentNullException()
    {

        //Act
        Func<Task> act = async () => await _productsService.DeleteProductByID(null);

        //Assert
        await act.Should().ThrowAsync<ArgumentNullException>();
    }

    #endregion

    #region UpdateProduct

    [Fact]
    public async Task UpdateProduct_ValidProductUpdate_ToBeSuccesfull()
    {
        //arrange
        ProductUpdateRequest productUpdateRequest = _fixture.Build<ProductUpdateRequest>().With(temp => temp.Id, Guid.NewGuid()).Create();
        Product product = productUpdateRequest.ToProduct();
        ProductResponse expectedProductResponse = product.ToProductResponse();

        _productRepositoryMock.Setup(temp => temp.EditProduct(It.IsAny<Product>())).ReturnsAsync(product);

        //act
        ProductResponse? actualProductresponse = await _productsService.EditProduct(productUpdateRequest);

        //assert
        actualProductresponse.Should().NotBeNull();
        actualProductresponse.Should().Be(expectedProductResponse);
        actualProductresponse?.Id.Should().Be(product.Id);
    }

    [Fact]
    public async Task UpdateProduct_NonExistentProductID_ReturnNull()
    {
        //arrange
        ProductUpdateRequest productUpdateRequest = _fixture.Build<ProductUpdateRequest>().With(temp => temp.Id, Guid.NewGuid()).Create();

        _productRepositoryMock.Setup(temp => temp.EditProduct(It.Is<Product>(p => p.Id == productUpdateRequest.Id))).ReturnsAsync((Product?)null);

        //act
        ProductResponse? actualProductresponse = await _productsService.EditProduct(productUpdateRequest);

        //assert
        actualProductresponse.Should().BeNull();
    }

    [Fact]
    public async Task UpdateProduct_InvalidProductID_ReturnsNull()
    {
        // Arrange
        ProductUpdateRequest productUpdateRequest = _fixture.Build<ProductUpdateRequest>()
            .With(x => x.Id, Guid.Empty)
            .Create();

        _productRepositoryMock
            .Setup(temp => temp.EditProduct(It.Is<Product>(p => p.Id == Guid.Empty)))
            .ReturnsAsync((Product?)null);

        // Act
        ProductResponse? actualProductResponse = await _productsService.EditProduct(productUpdateRequest);

        // Assert
        actualProductResponse.Should().BeNull();
        _productRepositoryMock.Verify(temp => temp.EditProduct(It.Is<Product>(p => p.Id == Guid.Empty)), Times.Once);
    }
    #endregion

    #region GetProductByID

    [Fact]
    public async Task GetProduct_ValidID_ToReturnProduct()
    {
        //arrange
        Product product = _fixture.Build<Product>().With(temp => temp.Id, Guid.NewGuid()).Create();
        ProductResponse expectedproductResponse = product.ToProductResponse();

        _productRepositoryMock.Setup(temp => temp.GetProductByProductID(It.Is<Guid>(g => g == product.Id))).ReturnsAsync(product);

        //act
        ProductResponse? actualProductResponse = await _productsService.GetProductByProductID(product.Id);

        //assert
        actualProductResponse.Should().NotBeNull();
        actualProductResponse.Should().Be(expectedproductResponse);
    }

    [Fact]
    public async Task GetProduct_NonExistentProductID_ToReturnNull()
    {
        //arrange
        Guid productID = Guid.NewGuid();

        _productRepositoryMock.Setup(temp => temp.GetProductByProductID(It.Is<Guid>(g => g == productID))).ReturnsAsync((Product?)null);

        //act
        ProductResponse? actualProductResponse = await _productsService.GetProductByProductID(productID);

        //assert
        actualProductResponse.Should().BeNull();
        _productRepositoryMock.Verify(temp => temp.GetProductByProductID(It.Is<Guid>(g => g == productID)), Times.Once);
    }

    [Fact]
    public async Task GetProduct_InvalidProductID_ToReturnNull()
    {
        //arrange
        Guid productID = Guid.Empty;

        _productRepositoryMock.Setup(temp => temp.GetProductByProductID(It.Is<Guid>(g => g == productID))).ReturnsAsync((Product?)null);

        //act
        ProductResponse? actualProductResponse = await _productsService.GetProductByProductID(productID);

        //assert
        actualProductResponse.Should().BeNull();
        _productRepositoryMock.Verify(temp => temp.GetProductByProductID(It.Is<Guid>(g => g == productID)), Times.Once);
    }

    #endregion

    #region GetAllProducts

    [Fact]
    public async Task GetAllProducts_ToBeEmptyList()
    {
        //arrange
        ProductsQuery query = new ProductsQuery();
        List<Product> products = [];
        _productRepositoryMock.Setup(temp => temp.GetAllProducts(It.Is<ProductsQuery>(q => q == query))).ReturnsAsync(products);

        //act
        var actualProducts = await _productsService.GetAllProducts(query);

        //assert
        actualProducts.Should().BeEmpty();
    }

    [Fact]
    public async Task GetAllProducts_NonEmptyList_ToReturnProducts()
    {
        //arrange
        ProductsQuery query = new ProductsQuery();
        List<Product> products = [_fixture.Build<Product>().Create(), _fixture.Build<Product>().Create(), _fixture.Build<Product>().Create()];

        List<ProductResponse> expectedProductResponses = products.Select(p => p.ToProductResponse()).ToList();

        _productRepositoryMock.Setup(temp => temp.GetAllProducts(It.Is<ProductsQuery>(q => q == query))).ReturnsAsync(products);

        //act
        var actualProductResponses = await _productsService.GetAllProducts(query);

        //assert
        actualProductResponses.Should().BeEquivalentTo(expectedProductResponses);
    }

    #endregion

    #region SortProducts

    [Fact]
    public async Task SortProducts_SortByNameAscending_ReturnProductsSortedByName()
    {
        //arrange
        ProductsQuery query = new ProductsQuery() { SortBy = "Name" };
        List<Product> products = [_fixture.Build<Product>().With(p=>p.Name, "Apple").Create(), _fixture.Build<Product>().With(p => p.Name, "Banana").Create(), _fixture.Build<Product>().With(p => p.Name, "Orange").Create()];

        _productRepositoryMock.Setup(temp => temp.GetAllProducts(It.Is<ProductsQuery>(q => q == query))).ReturnsAsync(products);

        //act
        var productsListResponse = await _productsService.GetAllProducts(query);

        //assert
        productsListResponse.Should().BeInAscendingOrder(p => p.Name);
    }

    [Fact]
    public async Task SortProducts_SortByInvalidString_ReturnProductsUnsorted()
    {
        //arrange
        ProductsQuery query = new ProductsQuery() { SortBy = "test" };
        List<Product> products = [_fixture.Build<Product>().With(p => p.Name, "Apple").Create(), _fixture.Build<Product>().With(p => p.Name, "Banana").Create(), _fixture.Build<Product>().With(p => p.Name, "Orange").Create()];

        List<ProductResponse> expectedProductResponses = products.Select(p => p.ToProductResponse()).ToList();

        _productRepositoryMock.Setup(temp => temp.GetAllProducts(It.Is<ProductsQuery>(q => q == query))).ReturnsAsync(products);

        //act
        var productsListResponse = await _productsService.GetAllProducts(query);

        //assert
        productsListResponse.Should().BeEquivalentTo(expectedProductResponses);
    }

    #endregion

    #region FilterProducts

    [Fact]
    public async Task FilterProducts_FilterByCategory_ReturnProductsOfCategory()
    {
        //arrange
        ProductsQuery query = new ProductsQuery() { Category = "Electronics" };
        List<Product> products = [
            _fixture.Build<Product>().With(p=>p.Category, "Electronics").Create(),
            _fixture.Build<Product>().With(p=>p.Category, "Clothing").Create(),
            _fixture.Build<Product>().With(p=>p.Category, "Electronics").Create()
            ];

        _productRepositoryMock.Setup(temp=>temp.GetAllProducts(It.Is<ProductsQuery>(q=>q==query))).ReturnsAsync(products.Where(p=>p.Category.Equals(query.Category, StringComparison.OrdinalIgnoreCase)).ToList());

        //act
        var filteredProducts = await _productsService.GetAllProducts(query);

        //assert
        filteredProducts.Should().HaveCount(2);
        filteredProducts.Should().AllSatisfy(product => product.Category.Should().Be(query.Category));
    }

    [Fact]
    public async Task FilterProducts_FilterByCategoryNoMatchingProducts_ReturnEmptyList()
    {
        //arrange
        ProductsQuery query = new ProductsQuery() { Category = "Books" };
        List<Product> products = [
            _fixture.Build<Product>().With(p=>p.Category, "Electronics").Create(),
            _fixture.Build<Product>().With(p=>p.Category, "Clothing").Create(),
            _fixture.Build<Product>().With(p=>p.Category, "Electronics").Create()
            ];

        _productRepositoryMock.Setup(temp => temp.GetAllProducts(It.Is<ProductsQuery>(q => q == query))).ReturnsAsync(products.Where(p => p.Category.Equals(query.Category, StringComparison.OrdinalIgnoreCase)).ToList());

        //act
        var filteredProducts = await _productsService.GetAllProducts(query);

        //assert
        filteredProducts.Should().HaveCount(0);
        filteredProducts.Should().BeEmpty();
    }

    #endregion
}
