using System;
using System.IO;

namespace FileSystemLibrary
{
    public static class FileManager
    {
        public static void CopyFile(string source, string destination) => File.Copy(source, destination, true);
        public static void CopyDirectory(string source, string destination)
        {
            foreach (var file in Directory.GetFiles(source))
            {
                File.Copy(file, Path.Combine(destination, Path.GetFileName(file)), true);
            }
        }
        public static void DeleteFile(string filePath) => File.Delete(filePath);
        public static void DeleteFiles(string[] filePaths) { foreach (var file in filePaths) File.Delete(file); }
        public static void DeleteFilesByMask(string directory, string pattern) { foreach (var file in Directory.GetFiles(directory, pattern)) File.Delete(file); }
        public static void MoveFile(string source, string destination) => File.Move(source, destination);
        public static void SearchWordInFile(string filePath, string word, string reportPath)
        {
            var lines = File.ReadLines(filePath).Where(line => line.Contains(word)).ToList();
            File.WriteAllLines(reportPath, lines);
        }
        public static void SearchWordInDirectory(string directory, string word, string reportPath)
        {
            var results = Directory.GetFiles(directory, "*.txt").SelectMany(file => File.ReadLines(file).Where(line => line.Contains(word)).Select(line => $"{file}: {line}")).ToList();
            File.WriteAllLines(reportPath, results);
        }
    }
}
