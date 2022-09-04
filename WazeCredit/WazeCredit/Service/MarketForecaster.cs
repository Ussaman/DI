using WazeCredit.Models;

namespace WazeCredit.Service
{
    public class MarketForecaster : IMarketForecaster
    {
        public MarketResult GetMarketPrediction()
        {
            //Call API to do some complex calculations and  current stock market forecast
            return new MarketResult
            {
                MarketCondition = Models.MarketCondition.StableUp
            };
        }


    }
}
