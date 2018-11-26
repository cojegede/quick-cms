using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentFetcher : IContentFetcher
    {
        private readonly HttpClient httpClient;
        private readonly IConfigurationLoader configurationLoader;

        public ContentFetcher(
            HttpClient httpClient,
            IConfigurationLoader configurationLoader)
        {
            this.httpClient = httpClient;
            this.configurationLoader = configurationLoader;
        }

        public async Task<string> GetContentAsync(string filePath)
        {
            if (Configuration.Current == null)
            {
                await configurationLoader.LoadConfigurationAsync();
            }
            Configuration configuration = Configuration.Current;
            switch (configuration.Mode)
            {
                case "GitHub":
                    return await httpClient.GetStringAsync(
                        GitHubUriHelpers.GetUserContentUri(
                            configuration.GitHub.User,
                            configuration.GitHub.Repository,
                            configuration.GitHub.Branch,
                            filePath));

                case null:
                case "Server":
                    return await httpClient.GetStringAsync($"/{filePath}");
            }

            throw new ArgumentException("Invalid hosting mode.");
        }
    }
}
