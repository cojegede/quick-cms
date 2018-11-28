using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Blog.Services
{
    public sealed class ContentParser : IContentParser
    {
        public ContentPage ParseContent(string content)
        {
            IReadOnlyDictionary<string, string> attributes = null;

            MatchCollection matches = Regex.Matches(content, "---", RegexOptions.Singleline);

            if (matches.Count >= 2)
            {
                Match first = matches[0];
                Match second = matches[1];

                if (first.Captures[0].Index == 0)
                {
                    string info = content.Substring(first.Captures[0].Index + first.Captures[0].Length, second.Captures[0].Index - first.Captures[0].Length);
                    attributes = ParseAttributes(info);
                }
                content = content.Substring(second.Captures[0].Index + second.Captures[0].Length);
            }
            return new ContentPage
            {
                Attributes = attributes,
                Content = content
            };
        }

        public static IReadOnlyDictionary<string, string> ParseAttributes(string info)
        {
            return info
              .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => x.Trim().Split(':'))
              .ToDictionary(x => x[0], x => x[1]);
        }
    }
}
