using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create the Model that represents the data that U shall fetch from the Web API. 
namespace ClientRecap.Models
{
    public class Trainee
    {
        public int TraineeId { get; set; }
       
        public string TraineeName { get; set; } = string.Empty;
        
        public string EmailAddress { get; set; } = string.Empty;
        
        public long PhoneNo { get; set; }
    }
}
