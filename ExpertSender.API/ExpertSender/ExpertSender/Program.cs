using ExpertSender.Application;
using ExpertSender.Infrastructure;
using ExpertSender.Persistance;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddPersistance(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
    options.AddPolicy(name: "MyAllowOrigins",
        builder =>
        {
            builder.WithOrigins(
                 "http://localhost:4200",    //FRONT-END
                                             //TODO Add project Identity Server 
                 "http://localhost:5001"     //Identity Server   
                ).AllowAnyHeader().AllowAnyMethod();
        }
    )
);

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "ExpertSender Api",
        Description = "Zarz¹dzanie pracownikami ",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Przemek",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseCors("MyAllowOrigins");

app.UseAuthorization();

app.MapControllers();

app.Run();
