using System;
namespace DI_Demo
{
    public class DataBaseSaver : ISaver // adding new savers is not an obstacle
    {
        public void Save(Document doc)
        {
            Console.WriteLine("Saving in db...");
        }
    }
}
