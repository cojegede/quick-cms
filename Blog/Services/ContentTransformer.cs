using Markdig;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentTransformer : IContentTransformer
    {
        public Task<string> TransformAsync(string content)
        {
            return Task.FromResult(
                Markdown.ToHtml(content));
        }
    }
}
