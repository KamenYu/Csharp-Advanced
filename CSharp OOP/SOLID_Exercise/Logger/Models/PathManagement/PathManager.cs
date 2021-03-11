using System.IO;
using Logger.Models.Contracts;

namespace Logger.Models.PathManagement
{
    public class PathManager : IPathManager
    {
        private readonly string currentPath;
        private readonly string filePath;
        private readonly string folderPath;

        private PathManager()
        {
            currentPath = GetCurrentPath();
        }

        public PathManager(string folderPath, string filePath)
            : this()
        {
            this.folderPath = folderPath;
            this.filePath = filePath;
        }

        public string CurrentDirectoryPath => Path.Combine(currentPath + folderPath);

        public string CurrentFilePath => Path.Combine(CurrentDirectoryPath + filePath);

        public void DoDirectoryORFileExist()
        {
            if (Directory.Exists(CurrentDirectoryPath) == false)
            {
                Directory.CreateDirectory(CurrentDirectoryPath);
            }

            File.AppendAllText(CurrentFilePath, string.Empty);
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}