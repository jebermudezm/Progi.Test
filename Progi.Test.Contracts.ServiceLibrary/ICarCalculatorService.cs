using Progi.Test.Contracts.ServiceLibrary.Params;

namespace Progi.Test.Contracts.ServiceLibrary
{
    public interface ICarCalculatorService
    {
        Task<decimal?> CalculatePrice(CarParameter param);
    }
}
