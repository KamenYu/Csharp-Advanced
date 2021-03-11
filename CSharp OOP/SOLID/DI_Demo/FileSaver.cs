using System.IO;

namespace DI_Demo
{
    public class FileSaver : ISaver
    {
        public void Save(Document doc)
        {
            using (StreamWriter sw = new StreamWriter("database.txt", true))
            {
                sw.WriteLine(doc.Text);
            }
        }
    }
}
