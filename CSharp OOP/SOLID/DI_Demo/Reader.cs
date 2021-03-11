using System.Collections.Generic;

namespace DI_Demo
{
    internal class Reader : IReader
    {
        public List<Document> Read()
        {
            List<Document> docs = new List<Document>();
            return docs;
        }
    }
}