namespace Blog.Services
{
    public class Configuration
    {
        public string Mode { get; set; }

        public GitHubRepositoryInfo GitHub { get; set; }

        public ContentLocations Locations { get; set; }
    }

    public class ContentLocations
    {
        public string Pages { get; set; }

        public string Posts { get; set; }
    }

    public class GitHubRepositoryInfo
    {
        public string User { get; set; }

        public string Repository { get; set; }

        public string Branch { get; set; }
    }

}
