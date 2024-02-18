

public class CarCalculatorControllerTests
{
    private readonly Mock<ICarCalculatorService> _mockService;
    private readonly CarCalculatorController _controller;

    public CarCalculatorControllerTests()
    {
        _mockService = new Mock<ICarCalculatorService>();
        _controller = new CarCalculatorController(_mockService.Object);
    }

    [Fact]
    public async Task Post_Params_ReturnsOKRequest()
    {
        // Arrange
        var dto = new CarDto
        {
                AssociationFee = 100,
                BasicFee = 39.8,
                SpecialFee = 7.96,
                StorageFee = 100,
                TotalPrice = 550.76
        };
        var param = new CarParameter { BasePrice = 398, CarType = 0 };

        _mockService.Setup(service => service.CalculatePrice(param)).ReturnsAsync(dto);

        // Act
        var result = await _controller.Get(param);

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        Assert.IsType<OkObjectResult>(okResult);
    }

    [Fact]
    public async Task Post_NullParams_ReturnsBadRequest()
    {
        // Arrange
        var dto = new CarDto
        {
            AssociationFee = 100,
            BasicFee = 39.8,
            SpecialFee = 7.96,
            StorageFee = 100,
            TotalPrice = 550.76
        };
        

        _mockService.Setup(service => service.CalculatePrice(null)).ReturnsAsync(dto);

        // Act
        var result = await _controller.Get(null);

        // Assert
        Assert.IsType<BadRequestObjectResult>(result);
    }


}
