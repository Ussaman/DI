using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WazeCredit.Models;
using WazeCredit.Models.ViewModels;
using WazeCredit.Service;
using WazeCredit.Utility.AppSettingsClasses;
using static WazeCredit.Service.MarketForecaster;

namespace WazeCredit.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMarketForecaster _marketForecaster;
        private readonly WazeForecstSettings _wazeOptions;
        private readonly StripeSettings _stripeOptions;
        private readonly SendGridSettings _sendGridOptions;
        private readonly TwilioSettings _twilioOptions;


        public HomeVM homeVM { get; set; }
        public HomeController(IMarketForecaster marketForecaster, IOptions<WazeForecstSettings> wazeOptions)
        {
            homeVM = new HomeVM();
            _marketForecaster = marketForecaster;
            this._wazeOptions = wazeOptions.Value;
        }

        public IActionResult Index()
        {
            
            
            MarketResult currentResult = _marketForecaster.GetMarketPrediction();
            switch (currentResult.MarketCondition)
            {
                case MarketCondition.StableDown:
                    homeVM.MarketForecast = "Market show stable down";
                    break;
                case MarketCondition.StableUp:
                    homeVM.MarketForecast = "Market show stable Up";
                    break;
                case MarketCondition.Volatile:
                    homeVM.MarketForecast = "Market show stable Volatile";
                    break;
                default:
                    homeVM.MarketForecast = "Apply for a credit card";
                    break;
            }
            return View(homeVM);
        }

        public IActionResult AllConfigSettings(
            [FromServices] IOptions<StripeSettings> stripeOptions,
            [FromServices] IOptions<SendGridSettings> sendGridOptions,
            [FromServices] IOptions<TwilioSettings> twilioOptions
            )
        {
            List<string> messages = new List<string>();
            messages.Add($"Waze config : " + _wazeOptions.ForecastTrackerEnabled);
            messages.Add($"Stripe Publishable Key: " + stripeOptions.Value.PublishableKey);
            messages.Add($"Stripe Secret key : " + stripeOptions.Value.SecretKey);
            messages.Add($"Send Grid Key : " + sendGridOptions.Value.SendGridKey);
            messages.Add($"Twilio Phone : " + twilioOptions.Value.PhoneNumber);
            messages.Add($"Twilio SID : " + twilioOptions.Value.AccountSid);
            messages.Add($"Twilio Token : " + twilioOptions.Value.AuthToken);
            return View(messages);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
