using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IContentTransformer
    {
        Task<string> TransformAsync(string content);
    }
}