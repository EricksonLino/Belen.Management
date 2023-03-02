using BelenHospital.Management.Application.Implementations;
using BelenHospital.Management.Application.Interfaces;
using BelenHospital.Management.Application.Profiles;
using BelenHospital.Management.Repository;
using BelenHospital.Management.Repository.Implementations;
using BelenHospital.Management.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ManagementContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped<IPatientsApplication, PatientsApplication>();
builder.Services.AddScoped<IPatientsRepository, PatientsRepository>();

builder.Services.AddScoped<ISpecialtysApplication, SpecialtysApplication>();
builder.Services.AddScoped<ISpecialtysRepository, SpecialtysRepository>();

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
