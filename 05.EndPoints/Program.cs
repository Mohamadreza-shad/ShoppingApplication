using _02.DomainServices.Configuration;
using _03.Infra.Extensions;
using _04.ApplicationServices.Configuration;
using _05.EndPoints.Configuration;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterAppServices();
builder.Services.RegisterInfraStructureServices();
builder.Services.RegisterDomainServiceExtension();
builder.Services.RegisterEndpointServices();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
