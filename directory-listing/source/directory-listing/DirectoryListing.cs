using System;
using System.Collections.Generic;
using System.IO;

namespace directory_listing
{
  public static class DirectoryListing
  {
    public static string mainPath = "";

    public static List<string> show(string path)
    {
      mainPath = path;
      displayItem(path);
      foreach (var item in Directory.EnumerateFileSystemEntries(path, "*.*", SearchOption.AllDirectories))
      {
        displayItem(item);
      }
      return null;
    }

    public static void displayItem(string item)
    {
      Console.ForegroundColor = isDirectory(item)
        ? ConsoleColor.Yellow
        : ConsoleColor.Green;

      var indentationLevel = getIndentationLevel(item);
      var tabCharacter = "  ";
      var indentation = "";
      for (int i = 0; i < indentationLevel; i++)
      {
        indentation += tabCharacter;
      }
      Console.WriteLine("{0}{1}", indentation, item);
    }

    public static bool isDirectory(string item)
    {
      var attributes = File.GetAttributes(item);
      return (attributes & FileAttributes.Directory) == FileAttributes.Directory;
    }

    public static int getIndentationLevel(string item)
    {
      var relativePath = item.Replace(mainPath, "");

      var count = 0;
      var slashCount = 0;
      var index = 0;
      while(index != -1)
      {
        if (index < relativePath.Length)
        {
          index = relativePath.IndexOf("\\", index + 1);
          if (index > 0)
          {
            slashCount++;
          }
        }
        else index = -1;
      }

      return slashCount;
    }
  }
}