using System;
using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IContentService
    {
        Task<ContentPage> GetPageAsync(string slug);
        Task<ContentPage> GetPostAsync(string slug);
        Task<ContentPage> GetPostAsync(DateTime date, string slug);
    }
}
