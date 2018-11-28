using System.Threading.Tasks;

namespace Blog.Services
{
    public sealed class Highlight
    {
        public static async Task InitAsync()
        {

            await Microsoft.JSInterop.JSRuntime.Current.InvokeAsync<object>("initHighlight");
        }
    }
}
