using System;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentService : IContentService
    {
        private readonly IContentFetcher contentFetcher;
        private readonly IContentParser contentParser;
        private readonly IContentUriResolver contentUriResolver;

        public ContentService(
            IContentFetcher contentFetcher,
            IContentParser contentParser,
            IContentUriResolver contentUriResolver)
        {
            this.contentFetcher = contentFetcher;
            this.contentParser = contentParser;
            this.contentUriResolver = contentUriResolver;
        }

        public async Task<ContentPage> GetPageAsync(string slug)
        {
            string contentUri = await contentUriResolver.ResolvePageUriAsync(slug);
            string content = await contentFetcher.GetContentAsync(contentUri);
            return contentParser.ParseContent(content);
        }

        public async Task<ContentPage> GetPostAsync(DateTime date, string slug)
        {
            string contentUri = await contentUriResolver.ResolvePostUriAsync(date, slug);
            string content = await contentFetcher.GetContentAsync(contentUri);
            return contentParser.ParseContent(content);
        }

        public async Task<ContentPage> GetPostAsync(string slug)
        {
            string contentUri = await contentUriResolver.ResolvePostUriAsync(slug);
            string content = await contentFetcher.GetContentAsync(contentUri);
            return contentParser.ParseContent(content);
        }
    }
}
