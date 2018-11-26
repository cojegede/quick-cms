using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IContentFetcher
    {
        Task<string> GetContentAsync(string filePath);
    }
}
