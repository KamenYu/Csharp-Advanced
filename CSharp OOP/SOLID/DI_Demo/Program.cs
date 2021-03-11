using System;

namespace DI_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IReader iR = new Reader();
            DocumentsController dc = new DocumentsController(new DataBaseSaver(), iR);
            while (true)
            {
                string text = Console.ReadLine();
                dc.AddDocument(text);
            }
        }

        static void TestingDocumentsController()
        {
            IReader iR = new Reader();
            var controller = new DocumentsController(new TestSaver(), iR);
        }
    }

    class TestSaver : ISaver // DI allows testing
    {
        public void Save(Document document)
        {
            Console.WriteLine("Testing");
        }
    }
}
