<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 2b27439 (adding migrations)
using Microsoft.EntityFrameworkCore;
using System;
using UserProfile.Api.Extensions;
using UserProfile.Data;
<<<<<<< HEAD
=======
using UserProfile.Api.Extensions;
>>>>>>> origin/master
=======
using UserProfile.Api.Extensions;
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
using UserProfile.Api.Extensions;
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 2b27439 (adding migrations)

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//regisgter dependencies
builder.Services.AddServices();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
//configure db context
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}
=======
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
//configure db context
builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
>>>>>>> 2b27439 (adding migrations)
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
