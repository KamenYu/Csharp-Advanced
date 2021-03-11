using System;
using AdapterPattern.Contracts;

namespace AdapterPattern
{
    public class HttpRequester : IHTTPRequester
    {
        private HTTPRequesterOLD old;
        public HttpRequester()
        {
            old = new HTTPRequesterOLD();
        }

        public void Get(string url)
        {
            old.GetURLWithTCP(url, new byte[20000], false);
        }
    }
}
