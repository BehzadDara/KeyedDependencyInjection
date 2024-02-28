namespace KeyedDependencyInjection;

public class Service2([FromKeyedServices("sms")] INotifyService notifyService)
{
    public string Notify() => notifyService.Send();
}
