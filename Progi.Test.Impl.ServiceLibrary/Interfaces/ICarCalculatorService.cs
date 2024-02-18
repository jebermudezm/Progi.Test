using Progi.Test.Contracts.ServiceLibrary.Params;
using Progi.Test.ServiceLibrary.Dto;

namespace Progi.Test.ServiceLibrary.Interfaces
{
    public interface ICarCalculatorService
    {
        Task<CarDto?> CalculatePrice(CarParameter param);
    }
}
