using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface ITraineeService
    {
        void AddNewTrainee(Trainee trainee);
        void RemoveTrainee(int id);
        void UpdateTrainee(int id, Trainee trainee);
        List<Trainee> GetAllTraines();
        Trainee FindTrainee(int id);    
    }
    internal class TraineeService : ITraineeService
    {
        private HttpClient _httpClient;
        private const string baseUrl = "http://localhost:5194/api/Trainees";
        public TraineeService(HttpClient client)
        {
            this._httpClient = client;
        }
        public void AddNewTrainee(Trainee trainee)
        {
            throw new NotImplementedException();
        }

        public  Trainee FindTrainee(int id)
        {
            var url = $"{baseUrl}/{id}";
            var response = this._httpClient.GetAsync(url).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            if(content != null)
            {
                return JsonSerializer.Deserialize<Trainee>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }else
            {
                return null;
            }
        }

        public List<Trainee> GetAllTraines()
        {
            var response = this._httpClient.GetAsync(baseUrl).Result;
           var content = response.Content.ReadAsStringAsync().Result;
            if(content != null)
            {
                return JsonSerializer.Deserialize<List<Trainee>>(content, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
            else
            {
                return new List<Trainee>();
            }
        }

        public void RemoveTrainee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTrainee(int id, Trainee trainee)
        {
            throw new NotImplementedException();
        }
    }
}
