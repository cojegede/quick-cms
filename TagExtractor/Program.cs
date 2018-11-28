using Blog.Services;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TagExtractor
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            ContentParser contentParser = new ContentParser();

            Dictionary<string, Dictionary<string, string>> tags = new Dictionary<string, Dictionary<string, string>>();

            foreach (string post in Directory.GetFiles("posts", "*.md"))
            {
                string content = await File.ReadAllTextAsync(post);
                ContentPage contentPage = contentParser.ParseContent(content);
                if (contentPage.Tags != null)
                {
                    foreach (string tag in contentPage.Tags)
                    {
                        if (!tags.TryGetValue(tag, out Dictionary<string, string> taggedPages))
                        {
                            taggedPages = new Dictionary<string, string>();
                            tags[tag] = taggedPages;
                        }

                        taggedPages.Add(Path.GetFileNameWithoutExtension(post), contentPage.Title);
                    }
                }
            }

            await File.WriteAllTextAsync("tags.json", JsonConvert.SerializeObject(tags));
        }
    }
}
