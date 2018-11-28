using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface ITagService
    {
        Task<IDictionary<string, IDictionary<string, string>>> GetTagsAsync();
    }
}