namespace KeyedDependencyInjection;

public class EmailService : INotifyService
{
    public string Send() => "Email sent!";
}
