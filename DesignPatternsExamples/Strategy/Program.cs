using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebApplication webApplication = new WebApplication(Models.Enums.BrowserType.Chrome);
            webApplication.SendAsyncRequestToServer("https://www.google.com");

            webApplication = new WebApplication(Models.Enums.BrowserType.InternetExplorer);
            webApplication.SendAsyncRequestToServer("https://www.google.com");

            Console.ReadLine();
        }
    }
}
