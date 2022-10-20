using Strategy.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Strategy.Models.Enums;

namespace Strategy
{
    public class WebApplication
    {
        private BrowserType _browserType;

        public WebApplication(BrowserType browserType)
        {
            _browserType = browserType;
        }

        public AsyncResponse SendAsyncRequestToServer(string url)
        {
            IAsyncRequestStrategy asyncRequestStrategy;
            AsyncResponse asyncResponse = null;

            switch (_browserType)
            {
                case BrowserType.InternetExplorer:
                    asyncRequestStrategy = new XmlHttpRequestApi();
                    return asyncRequestStrategy.SendRequest(url);
                case BrowserType.Chrome:
                    asyncRequestStrategy = new FetchApiRequest();
                    return asyncRequestStrategy.SendRequest(url);
                default:
                    break;
            }

            return asyncResponse;
        }
    }
}
