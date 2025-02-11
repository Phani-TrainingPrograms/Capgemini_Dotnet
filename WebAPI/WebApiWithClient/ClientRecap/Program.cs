using ClientRecap.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClientRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHttpClient<ITraineeService, TraineeService>();
                })
                .Build();

            var myService = host.Services.GetRequiredService<ITraineeService>();
            var data = myService.GetAllTraines().Result;
            foreach(var trainee in data)
            {
                Console.WriteLine(trainee.TraineeName);
            }
        }
    }
}
