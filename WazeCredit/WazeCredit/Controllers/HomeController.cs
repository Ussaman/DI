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
        private readonly StripeSettings _stripeOptions;
        private readonly SendGridSettings _sendGridOptions;
        private readonly TwilioSettings _twilioOptions;
        private readonly WazeForecstSettings _wazeOptions;

        public HomeVM homeVM { get; set; }
        public HomeController(IMarketForecaster marketForecaster, 
            IOptions<StripeSettings> stripeOptions, 
            IOptions<SendGridSettings> sendGridOptions, 
            IOptions<TwilioSettings> twilioOptions, 
            IOptions<WazeForecstSettings> wazeOptions)
        {
            homeVM = new HomeVM();
            _marketForecaster = marketForecaster;
            _stripeOptions = stripeOptions.Value;
            _sendGridOptions = sendGridOptions.Value;
            _twilioOptions = twilioOptions.Value;
            _wazeOptions = wazeOptions.Value;
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

        public IActionResult AllConfigSettings()
        {
            List<string> messages = new List<string>();
            messages.Add($"Waze config : " + _wazeOptions.ForecastTrackerEnabled);
            messages.Add($"Stripe Publishable Key: " + _stripeOptions.PublishableKey);
            messages.Add($"Stripe Secret key : " + _stripeOptions.SecretKey);
            messages.Add($"Send Grid Key : " + _sendGridOptions.SendGridKey);
            messages.Add($"Twilio Phone : " + _twilioOptions.PhoneNumber);
            messages.Add($"Twilio SID : " + _twilioOptions.AccountSid);
            messages.Add($"Twilio Token : " + _twilioOptions.AuthToken);
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
