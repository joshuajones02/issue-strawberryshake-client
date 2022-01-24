namespace ConsoleApp1
{
    using System;
    using System.Text.Json;
    using Microsoft.Extensions.DependencyInjection;

    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection() as IServiceCollection;
            services.AddConferenceClient();
            var provider = services.BuildServiceProvider();
            var client = provider.GetService<IConferenceClient>();


            Console.WriteLine("Hello World!");
            var sessions = client.GetSessions.ExecuteAsync();

            Console.WriteLine(JsonSerializer.Serialize(sessions, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
