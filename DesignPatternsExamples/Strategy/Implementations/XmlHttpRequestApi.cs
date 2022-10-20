﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Implementations
{
    public class XmlHttpRequestApi : IAsyncRequestStrategy
    {
        public AsyncResponse SendRequest(string url)
        {
            AsyncResponse response = new AsyncResponse();

            // Mock logic implementation
            Console.WriteLine("Sent async network request using XHR");

            return response;
        }
    }
}
