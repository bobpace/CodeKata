using System;
using System.Collections.Generic;
using System.IO;

namespace directory_listing
{
    public class FileSystemSearcher : ISearchFiles
    {
        public IEnumerable<string> ListContents(string path)
        {
            return ListContents(path, "*.*");
        }

        public IEnumerable<string> ListContents(string path, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, SearchOption.AllDirectories);
        }
    }
}