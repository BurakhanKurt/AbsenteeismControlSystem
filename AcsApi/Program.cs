using AcsApi.AutoMapper;
using AcsApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
.AddNewtonsoftJson(opt =>
{
    opt.SerializerSettings.ReferenceLoopHandling =
    Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Extensions
builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.RegisterRepositories();
builder.Services.ConfigureServices();
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.ConfigureJWT(builder.Configuration);
// Configure Identity
builder.Services.ConfigureIdentity();

var app = builder.Build();

app.ConfigureExceptionHandler();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
