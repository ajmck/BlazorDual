using BlazorDual.Common;
using BlazorDual.Common.Data;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDual.Common
{
    public class WasmStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<WeatherForecastService>();
            
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
