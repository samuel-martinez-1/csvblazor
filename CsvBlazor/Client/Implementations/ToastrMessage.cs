using CsvBlazor.Client.Core;
using Microsoft.JSInterop;
using System.Text.Json;

namespace CsvBlazor.Client.Implementations
{
    public class ToastrMessage : IUiMessage
    {
        private readonly IJSRuntime js;

        public ToastrMessage(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task Success(string message)
        {
            var config = JsonSerializer.Serialize(new ToastrOptionsInternal());
            Console.WriteLine(config);
            await js.InvokeVoidAsync("toastr.success", message, "", config);
        }
        public async Task Info(string message)
        {
            await js.InvokeVoidAsync("toastr.info", message);
        }
        public async Task Warning(string message)
        {
            await js.InvokeVoidAsync("toastr.warning", message);
        }
        public async Task Error(string message)
        {
            await js.InvokeVoidAsync("toastr.error", message);
        }
    }
    internal class ToastrOptionsInternal
    {
        public bool closeButton { get; set; } = true;
    }
}
