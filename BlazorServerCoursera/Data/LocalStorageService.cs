using Microsoft.JSInterop;

namespace BlazorServerCoursera.Data;

public class LocalStorageService
{
    private IJSRuntime _jsRuntime;
    
    public LocalStorageService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }
    
    public async Task SetItemAsync(string key, string value)
    {
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
    }

    public async Task<string> GetItemAsync(string key)
    {
        var result = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        return result;
    }
}