using System;
namespace AdapterPattern.Contracts
{
    public interface IHTTPRequester
    {
        void Get(string url);
    }
}
