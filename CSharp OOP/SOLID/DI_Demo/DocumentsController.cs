using System.Collections.Generic;

namespace DI_Demo
{
    public class DocumentsController
    {
        //private FileSaver saver = new FileSaver(); // we do not work with an Interface, also the code is hard to test
        private ISaver saver; // this is the solution, anythind that uses ISaver
        private IReader reader;
        public DocumentsController // easy to read, but many parameters
            (ISaver saver,
            IReader reader)
        {
            this.saver = saver;  // constructor injection
            this.reader = reader;
        }

        public void AddDocument(string text)
        {
            Document doc = new Document() { Text = text };
            saver.Save(doc);
        }

        public List<Document> ReadDocuments() // the method has access to ISaver, but does not use it, that is not that bad
        {
            return reader.Read();
        }
    }
}
