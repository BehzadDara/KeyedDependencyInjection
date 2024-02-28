using KeyedDependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddKeyedSingleton<INotifyService, EmailService>("email");
builder.Services.AddKeyedSingleton<INotifyService, SMSService>("sms");

builder.Services.AddSingleton<Service1>();
builder.Services.AddSingleton<Service2>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/service1", (Service1 wrapper) => wrapper.Notify());
app.MapGet("/service2", (Service2 wrapper) => wrapper.Notify());

app.Run();
