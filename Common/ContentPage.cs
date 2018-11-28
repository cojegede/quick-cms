using System.Collections.Generic;
using System.Linq;

namespace Blog.Services
{
    public sealed class ContentPage
    {
        private IEnumerable<string> tags;

        public string Title => GetAttributeOrDefault("title");

        public string Author => GetAttributeOrDefault("author");

        public string Date => GetAttributeOrDefault("date");

        public string Excerpt => GetAttributeOrDefault("excerpt");

        public string Image => GetAttributeOrDefault("image");

        public IEnumerable<string> Tags => (tags = GetAttributeOrDefault("tags")?
            .Split(',')?
            .Select(tag => tag.Trim()));

        public string Content { get; set; }

        public IReadOnlyDictionary<string, string> Attributes { get; set; }

        private string GetAttributeOrDefault(string key)
        {
            Attributes.TryGetValue(key, out string result);
            return result;
        }
    }
}
