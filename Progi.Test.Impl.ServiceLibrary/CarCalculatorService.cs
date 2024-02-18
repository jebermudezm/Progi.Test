using Progi.Test.Contracts.ServiceLibrary.Params;
using Progi.Test.ServiceLibrary.Dto;
using Progi.Test.ServiceLibrary.Enum;
using Progi.Test.ServiceLibrary.Interfaces;

namespace Progi.Test.ServiceLibrary
{
    public class CarCalculatorService : BaseService, ICarCalculatorService
    {
        public async Task<CarDto> CalculatePrice(CarParameter param)
        {
            CarDto response = GetPrice(param);
            return response;
        }

        
    }
}