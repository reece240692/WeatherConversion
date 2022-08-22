using Newtonsoft.Json;
using WeatherConversion.Core.Services;

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{

    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200",
                                              "http://localhost:7200");
                      });

});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//app.UseCors();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
   
    

    app.UseCors(MyAllowSpecificOrigins);


}

app.UseHttpsRedirection();


app.MapGet("/", (double temp, char unitFrom,char unitTo) =>
{
    try
    {
        TempConverterServices TCS = new();
        var result = TCS.Convert(temp, char.ToUpper(unitFrom), char.ToUpper(unitTo));
        var convertedResult = JsonConvert.SerializeObject(result);
        return convertedResult;

    }
    catch(BadHttpRequestException)
    {
        var result ="Bad Request! Please Check input values";
        return JsonConvert.SerializeObject(result);
    }

    catch(Exception)
    {
        var result = "Oops! Something went wrong...";
      return JsonConvert.SerializeObject(result);
    }


})
.WithName("GetConverter");

app.Run();
