using Progi.Test.Contracts.ServiceLibrary.Params;
using Progi.Test.ServiceLibrary.Dto;
using Progi.Test.ServiceLibrary.Enum;
using cons = Progi.Test.ServiceLibrary.Const.Constants;

namespace Progi.Test.ServiceLibrary
{
    public abstract class BaseService
    {
        internal CarDto GetPrice(CarParameter param)
        {
            double basicFee = CalculateBasicFee(param.BasePrice, param.CarType);

            double specialFee = param.CarType == CarType.Common ?
                param.BasePrice * cons.COMMONCARSPECIALFEERATE :
                param.BasePrice * cons.LUXURYCARSPECIALFEERATE;

            double associationFee = CalculateAssociationFee(param.BasePrice);

            double totalPrice = param.BasePrice + basicFee + specialFee + associationFee + cons.STORAGEFEE;

            var response = new CarDto
            {
                BasicFee = basicFee,
                SpecialFee = specialFee,
                AssociationFee = associationFee,
                StorageFee = cons.STORAGEFEE,
                TotalPrice = totalPrice
            };
            return response;
        }

        private double CalculateBasicFee(double vehicleBasePrice, CarType carType)
        {
            double minBasicFee = carType == CarType.Common ? cons.COMMONCARMINBASICFEE : cons.LUXURYCARMINBASICFEE;
            double maxBasicFee = carType == CarType.Common ? cons.COMMONCARMAXBASICFEE : cons.LUXURYCARMAXBASICFEE;

            return Math.Min(Math.Max(vehicleBasePrice * cons.BASICUSERFEE, minBasicFee), maxBasicFee);
        }

        private double CalculateAssociationFee(double vehicleBasePrice)
        {
            if (vehicleBasePrice <= cons.ASSOCIATIONFEERANGE1)
                return cons.ASSOCIATIONFEE1;
            else if (vehicleBasePrice <= cons.ASSOCIATIONFEERANGE2)
                return cons.ASSOCIATIONFEE2;
            else if (vehicleBasePrice <= cons.ASSOCIATIONFEERANGE3)
                return cons.ASSOCIATIONFEE3;
            else
                return cons.ASSOCIATIONFEE4;
        }
    }
}
