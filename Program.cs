using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Serilog;
using Serilog.Formatting.Compact;
using System;

namespace CIS174_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                            .Enrich.FromLogContext()
                            .WriteTo.Console(new CompactJsonFormatter())
                            .CreateLogger();
             
            try
            {
                Log.Information("Starting up");
                CreateWebHostBuilder(args).Build().Run();

            }catch(Exception ex)
            {
                Log.Fatal(ex, "Host terminated unxpectedly");
            }finally
            {
                Log.CloseAndFlush();
            }
           
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseSerilog()
                   .UseStartup<Startup>();
    }
}
