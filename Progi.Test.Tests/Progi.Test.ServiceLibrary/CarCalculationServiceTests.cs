
public class CarCalculationServiceTests
{
    private readonly CarCalculatorService _carCalculatorService;

    public CarCalculationServiceTests()
    {
        _carCalculatorService = new CarCalculatorService();
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_398_And_CarType_Is_Common()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 398, CarType = 0};
        
        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 550.76);
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_501_And_CarType_Is_Common()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 501, CarType = 0 };

        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 671.02);
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_57_And_CarType_Is_Common()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 57, CarType = 0 };

        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 173.14);
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_1800_And_CarType_Is_Luxuri()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 1800, CarType = (Progi.Test.ServiceLibrary.Enum.CarType)1 };

        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 2167);
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_1100_And_CarType_Is_Common()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 1100, CarType = 0 };

        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 1287);
    }

    [Fact]
    public async Task CalculatePrice_When_Price_Is_1000000_And_CarType_Is_Luxuri()
    {
        // Arrange
        CarParameter carParameter = new CarParameter { BasePrice = 1000000, CarType = (Progi.Test.ServiceLibrary.Enum.CarType)1 };

        // Act
        var result = await _carCalculatorService.CalculatePrice(carParameter);

        // Assert
        Assert.Equal(result.TotalPrice, 1040320);
    }

}
