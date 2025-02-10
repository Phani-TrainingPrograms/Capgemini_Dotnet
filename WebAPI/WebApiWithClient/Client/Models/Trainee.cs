using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Client.Models
{
    public class Trainee
    {
        public int TraineeId { get; set; }
        public string TraineeName { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty ;
        public long PhoneNo { get; set; }
        public override string ToString()
        {
            return $"{TraineeId}: {TraineeName}, {PhoneNo}";
        }
    }
}
