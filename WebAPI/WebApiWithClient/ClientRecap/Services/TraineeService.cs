using ClientRecap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
//Add the following packages:
//dotnet add package Microsoft.Extensions.DependencyInjection
//dotnet add package Microsoft.Extensions.Http
namespace ClientRecap.Services
{
    internal class TraineeService : ITraineeService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "http://localhost:5194/api/Trainees";

        public TraineeService(HttpClient client)
        {
            this._httpClient = client;
        }
        public Task AddNewTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Trainee>> GetAllTraines()
        {
            var response = await this._httpClient.GetAsync(baseUrl);
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content); //Remove it later
            if(content != null)
            {
                return JsonSerializer.Deserialize<List<Trainee>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else
            {
                throw new Exception("data not accessible");
            }
            
        }

        public Task<Trainee> GetTraineeById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
