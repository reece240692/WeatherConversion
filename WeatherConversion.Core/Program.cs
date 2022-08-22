using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using WeatherConversion.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
  
}

app.UseHttpsRedirection();


app.MapGet("/", (double temp, char unitFrom,char unitTo) =>
{
    TempConverterServices TCS = new();
    var result = TCS.Convert(temp, unitFrom, unitTo);
   var convertedResult= JsonConvert.SerializeObject(result);
    return convertedResult;
   
})
.WithName("GetConverter");

app.Run();
