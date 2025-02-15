using Moq; //Add the Nuget package to Moq the Tests..

[TestFixture]
public class NotificationServiceTests
{
    [Test]
    public void NotifyUser_ShouldCallSendEmailOnce()
    {
        var mockEmailService = new Mock<IEmailService>();
        var notificationService = new NotificationService(mockEmailService.Object);

        notificationService.NotifyUser("test@example.com", "Hello!");

        mockEmailService.Verify(m => m.SendEmail("test@example.com", "Hello!"), Times.Once);
    }
}
