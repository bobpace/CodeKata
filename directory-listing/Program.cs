namespace directory_listing
{
  class Program
  {
    static void Main(string[] args)
    {
      var path = @"c:\sandbox";
      DirectoryListing.show(path);
    }
  }
}
