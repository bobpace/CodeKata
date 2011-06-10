using System.Collections.Generic;

namespace directory_listing
{
    public interface ISearchFiles
    {
        IEnumerable<string> ListContents(string path);
        IEnumerable<string> ListContents(string path, string searchPattern);
    }
}