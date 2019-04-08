using Blog.Services;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Highlight>();

            services.AddSingleton<IConfigurationService, ConfigurationService>();
            services.AddSingleton<IConfigurationLoader, ConfigurationLoader>();
            services.AddSingleton<IContentService, ContentService>();
            services.AddSingleton<IContentFetcher, ContentFetcher>();
            services.AddSingleton<IContentParser, ContentParser>();
            services.AddSingleton<IContentTransformer, ContentTransformer>();
            services.AddSingleton<ITagService, TagService>();
            services.AddSingleton<IContentUriResolver, ContentUriResolver>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
