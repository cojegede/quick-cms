using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IConfigurationService
    {
        Task<Configuration> GetConfigurationAsync();
    }
}