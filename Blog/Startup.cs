using Blog.Services;
using HeyRed.MarkdownSharp;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blog
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfigurationLoader, ConfigurationLoader>();
            services.AddSingleton<IContentFetcher, ContentFetcher>();
            services.AddSingleton<IContentPageParser, ContentPageParser>();
            services.AddSingleton<Markdown>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
