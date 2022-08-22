using WeatherConversion.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/", (double temp, char unitFrom, char unitTo) =>
{
    TempConverterServices TCS = new();
    return TCS.Convert(temp, unitFrom, unitTo);
   
})
.WithName("GetConverter");

app.Run();
