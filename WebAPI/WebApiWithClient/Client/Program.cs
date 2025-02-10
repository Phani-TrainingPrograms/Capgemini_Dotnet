using Client.Models;
using Client.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Net.Http.Headers;

namespace Client
{

    class AppComponent
    {
        private readonly ITraineeService traineeService;

        public AppComponent(ITraineeService service)
        {
            this.traineeService = service;
        }

        public List<Trainee> GetAll()
        {
            var data = this.traineeService.GetAllTraines();
            return (List<Trainee>)data;
        }

        public Trainee GetTrainee(int id)
        {
            var data = this.traineeService.FindTrainee(id);
            return data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                     services.AddHttpClient<ITraineeService, TraineeService>();
                      services.AddTransient<AppComponent>();  
                })
                .Build();
            var app = host.Services.GetRequiredService<AppComponent>();
            var rec = app.GetTrainee(2);
            if(rec != null)
            {
                Console.WriteLine(rec);
            }
        }
    }
}
