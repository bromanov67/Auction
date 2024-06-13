using FluentValidation;
using MediatR;
using System.Reflection;
using static FluentValidation.AssemblyScanner;


var builder = WebApplication.CreateBuilder(args);

var assemblies = AppDomain.CurrentDomain.GetAssemblies();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var openGenericType = typeof(IValidator<>);
var types = assemblies
    .SelectMany(a => a.GetTypes())
    .Where(t => !t.IsAbstract && !t.IsGenericTypeDefinition);

foreach (var type in types)
{
    var validatorInterface = type
        .GetInterfaces()    
        .FirstOrDefault(t => t.IsGenericType && t.GetGenericTypeDefinition() == openGenericType);

    if (validatorInterface != null)
        builder.Services.AddSingleton(validatorInterface, type);

}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
