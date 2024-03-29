﻿namespace Blog.Services
{
    public static class GitHubUriHelpers
    {
        public static string GetUserContentUri(string user, string repository, string branch, string filePath)
        {
            return $"https://raw.githubusercontent.com/{user}/{repository}/{branch}/{filePath}";
        }
    }

}
