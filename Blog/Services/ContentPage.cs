using System.Collections.Generic;

namespace Blog.Services
{
    public sealed class ContentPage
    {
        public string Title => Attributes["title"];

        public string Author => Attributes["author"];

        public string Content { get; set; }

        public IReadOnlyDictionary<string, string> Attributes { get; set; }
    }
}
