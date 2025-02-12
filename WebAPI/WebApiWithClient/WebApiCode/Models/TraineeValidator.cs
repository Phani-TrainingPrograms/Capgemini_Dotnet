using FluentValidation;

namespace WebApiCode.Models
{
    public class TraineeValidator : AbstractValidator<Trainee>
    {
        
        public TraineeValidator()
        {
            RuleFor(x => x.TraineeName)
                .NotEmpty().WithMessage("Name is required")
                .Length(5, 50).WithMessage("Name shouild be b/w 5 to 50 charecters");

            RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email is not in a proper format");
        }
    }
}
