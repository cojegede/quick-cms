using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class ContentFetcher : IContentFetcher
    {
        private readonly HttpClient httpClient;
        private readonly IConfigurationService configurationService;

        public ContentFetcher(
            HttpClient httpClient,
            IConfigurationService configurationService)
        {
            this.httpClient = httpClient;
            this.configurationService = configurationService;
        }

        public async Task<string> GetContentAsync(string filePath)
        {
            Configuration configuration = await configurationService.GetConfigurationAsync();
            switch (configuration.Mode)
            {
                case "GitHub":
                    return await httpClient.GetStringAsync(
                        GitHubUriHelper.GetUserContentUri(
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
