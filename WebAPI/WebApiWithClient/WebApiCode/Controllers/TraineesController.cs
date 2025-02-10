using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCode.Models;

namespace WebApiCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TraineesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Trainee>> GetAll()
        {
            var data =this._context.Trainees.ToList();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<Trainee> GetById(int id)
        {
            var data = this._context.Trainees.SingleOrDefault(t => t.TraineeId == id);
            return Ok(data);
        }

        [HttpPost]
        public ActionResult<Trainee> AddNewTrainee([FromBody]Trainee newTrainee)
        {
            this._context.Trainees.Add(newTrainee);
            this._context.SaveChanges();
            var rec = this._context.Trainees.OrderBy(t =>t.TraineeId).LastOrDefault();
            return Ok(rec);
        }

        [HttpPut("{id}")]
        public ActionResult<Trainee> UpdateTrainee(int id, [FromBody] Trainee updatedTrainee)
        {
            var rec = this._context.Trainees.FirstOrDefault(t =>t.TraineeId == id);
            if(rec == null)
                return NotFound("Trainee not found");
            rec.TraineeName = updatedTrainee.TraineeName;
            rec.EmailAddress = updatedTrainee.EmailAddress;
            rec.PhoneNo = updatedTrainee.PhoneNo;
            this._context.SaveChanges();
            return Ok(rec);
        }

        [HttpDelete]
        public ActionResult<string> DeleteTrainee(int id)
        {
            var found = this._context.Trainees.FirstOrDefault(t =>t.TraineeId == id);
            if (found == null)
            {
                return NotFound("Trainee not found to Delete");
            }
            this._context.Remove(found);
            this._context.SaveChanges();
            return Ok("Trainee removed successfully");
        }
    }
}
