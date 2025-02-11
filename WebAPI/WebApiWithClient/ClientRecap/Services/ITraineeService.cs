using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientRecap.Models;

namespace ClientRecap.Services
{
    internal interface ITraineeService
    {
        Task AddNewTrainee(Trainee trainee);
        Task<List<Trainee>> GetAllTraines();
        Task<Trainee> GetTraineeById(int id);
    }
}
