namespace KeyedDependencyInjection;

public class Service1([FromKeyedServices("email")] INotifyService notifyService)
{
    public string Notify() => notifyService.Send();
}