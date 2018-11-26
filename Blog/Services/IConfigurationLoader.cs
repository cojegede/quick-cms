using System.Threading.Tasks;

namespace Blog.Services
{
    public interface IConfigurationLoader
    {
        Task<Configuration> LoadConfigurationAsync();
    }
}