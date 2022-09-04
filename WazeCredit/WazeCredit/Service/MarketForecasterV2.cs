using WazeCredit.Models;

namespace WazeCredit.Service
{
    public class MarketForecasterV2 : IMarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            //Call API to do some complex calculations and  current stock market forecast
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.Volatile
            };
        }

        
    }
}
