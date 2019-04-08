//using Ganss.XSS;
using Markdig;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentTransformer : IContentTransformer
    {
        //private HtmlSanitizer sanitizer;

        public ContentTransformer() 
        {
            //sanitizer = new HtmlSanitizer();
            //sanitizer.AllowedAttributes.Add("class");
        }

        public Task<string> TransformAsync(string content)
        {
            var html = Markdown.ToHtml(content);
            //var sanitized = sanitizer.Sanitize(html);

            return Task.FromResult(html);
        }
    }
}
