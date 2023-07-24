using BlazorServerCoursera.Data;

namespace BlazorServerCoursera;

public class StartUp
{
    public IConfiguration Configuration;
    
    public StartUp(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MyCustomDataService>();
    }
}