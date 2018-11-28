using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class TagService : ITagService
    {
        private readonly IContentFetcher contentFetcher;

        public TagService(IContentFetcher contentFetcher)
        {
            this.contentFetcher = contentFetcher;
        }

        public async Task<IDictionary<string, IDictionary<string, string>>> GetTagsAsync()
        {
            return Json.Deserialize<IDictionary<string, IDictionary<string, string>>>
                (await contentFetcher.GetContentAsync("tags.json"));
        }
    }
}
