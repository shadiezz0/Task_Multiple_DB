using Microsoft.Extensions.Configuration;
using Task_Multiple_DB;
using Task_Multiple_DB.Models.Sec_Mdl;
using Task_Multiple_DB.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//UseQueryTrackingBehavior (for reading data only mode)
builder.Services.AddDbContext<DbContext1>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DB1ConnectionString")));
builder.Services.AddDbContext<DbContext2>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB2ConnectionString")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDB1Repository, DB1Repository>();
builder.Services.AddScoped<IDB2Repository, DB2Repository>();

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
