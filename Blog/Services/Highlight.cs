using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Blog.Services
{
    public sealed class Highlight
    {
        private readonly IJSRuntime jSRuntime;

        public Highlight(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        public async Task InitAsync()
        {

            await jSRuntime.InvokeAsync<object>("initHighlight");
        }
    }
}
