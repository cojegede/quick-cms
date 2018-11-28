using System;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IContentUriResolver
    {
        Task<string> ResolvePageUriAsync(string slug);
        Task<string> ResolvePostUriAsync(string slug);
        Task<string> ResolvePostUriAsync(DateTime date, string slug);
    }
}
