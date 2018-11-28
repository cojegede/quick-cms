using System;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentUriResolver : IContentUriResolver
    {
        private readonly IConfigurationService configurationService;

        public ContentUriResolver(
            IConfigurationService configurationService)
        {
            this.configurationService = configurationService;
        }

        public async Task<string> ResolvePageUriAsync(string slug)
        {
            Configuration configuration = await configurationService.GetConfigurationAsync();
            return $"{configuration.Locations.Pages}/{slug}.md";
        }

        public async Task<string> ResolvePostUriAsync(string slug)
        {
            Configuration configuration = await configurationService.GetConfigurationAsync();
            return $"{configuration.Locations.Posts}/{slug}.md";
        }

        public async Task<string> ResolvePostUriAsync(DateTime date, string slug)
        {
            Configuration configuration = await configurationService.GetConfigurationAsync();
            string d = date.ToString("yyyy-MM-dd");
            return $"{configuration.Locations.Posts}/{d}-{slug}.md";
        }
    }
}
