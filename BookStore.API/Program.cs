using BookStore.Core.Abstracts.Repositories;
using BookStore.Core.Abstracts.Services;
using BookStore.Core.UnitOfWorks;
using BookStore.Repository.Concrete;
using BookStore.Repository.Context;
using BookStore.Repository.UnitOfWorks;
using BookStore.Service.Concrete;
using BookStore.Service.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Dependency Injections
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>),typeof(Service<>));
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name));

});
// AutoMapper
builder.Services.AddAutoMapper(typeof(MapProfile));


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
