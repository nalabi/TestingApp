using Microsoft.Extensions.DependencyInjection;
using API.Entities;
using API.Data;

namespace API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();
            var Services = scope.ServiceProvider;
            try
            {
                var context = Services.GetRequiredService<DataContext>;
            }
            catch (Exception ex)
            {

            }
        }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();

                    });
        }
    }

