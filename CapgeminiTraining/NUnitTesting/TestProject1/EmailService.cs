public interface IEmailService
{
    bool SendEmail(string email, string message);
}

public class NotificationService
{
    private readonly IEmailService _emailService;

    public NotificationService(IEmailService emailService)
    {
        _emailService = emailService;
    }

    public void NotifyUser(string email, string message)
    {
        _emailService.SendEmail(email, message);
    }
}
