using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EmployeeContext>(options =>
        options.UseInMemoryDatabase("EmployeeDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<EmployeeContext>();
    context.Database.EnsureCreated();

    if (!context.Employees.Any())
    {
        context.Employees.Add(new Employee
        {
            Name = "John",
            Age = 30,
            YearsOfService = 5
        });
        context.Employees.Add(new Employee
        {
            Name = "Jane",
            Age = 25,
            YearsOfService = 3
        });
        context.SaveChanges();
    }
}
app.Run();
