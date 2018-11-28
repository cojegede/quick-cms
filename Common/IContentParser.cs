namespace Blog.Services
{
    public interface IContentParser
    {
        ContentPage ParseContent(string content);
    }
}
