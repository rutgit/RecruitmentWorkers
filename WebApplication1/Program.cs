using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.BL;
using WebApplication1.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IWorkerDAL, WorkerDAL>();
builder.Services.AddScoped<IWorkerService, WorkerService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", //give it the name you want
                  builder =>
                  {
                      builder.WithOrigins("http://localhost:4200",
                                           "development web site")
                                          .AllowAnyHeader()
                                          .AllowAnyMethod()
                                          ;
                  });

});

builder.Services.AddDbContext<RecruitmentContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("RecruitmentContextSchool")));
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
app.UseCors("CorsPolicy");
app.Run();
