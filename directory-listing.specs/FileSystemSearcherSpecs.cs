 using System.Collections.Generic;
 using System.Linq;
 using Machine.Specifications;
 using developwithpassion.specifications.moq;
 using developwithpassion.specifications.extensions;

namespace directory_listing.specs
{
    [Subject(typeof(FileSystemSearcher))]
    public class FileSystemSearcherSpecs
    {
        public abstract class concern : Observes<ISearchFiles,
                                            FileSystemSearcher>
        {
            Establish c = () =>
            {
                path = @"C:\home";
            };

            public static string path;
            public static IEnumerable<string> result;
        }

        public class when_listing_contents_of_a_path_with_a_search_pattern : concern
        {
            Because b = () =>
                result = sut.ListContents(path, "*.cs");

            It should_only_get_files_matching_the_pattern = () =>
            {
                result.ToList().Count.ShouldBeGreaterThan(1);
                result.Any(x => !x.Contains(".cs")).ShouldBeFalse();
            };
        }

        public class when_listing_contents_of_a_path : concern
        {
            Because b = () =>
                result = sut.ListContents(path);

            It should_get_all_files_recursively_in_all_folders_under_path = () =>
                result.ToList().Count.ShouldBeGreaterThan(0);
        }
    }
}
