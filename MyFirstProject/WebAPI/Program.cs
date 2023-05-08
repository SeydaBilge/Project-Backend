using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserDal, EFUserDal>();

builder.Services.AddSingleton<IAssessmentBookService, AssessmentBookManager>();
builder.Services.AddSingleton<IAssessmentBookDal, EFAssessmentBookDal>();

builder.Services.AddSingleton<IAssessmentMovieService, AssessmentMovieManager>();
builder.Services.AddSingleton<IAssessmentMovieDal, EFAssessmentMovieDal>();

builder.Services.AddSingleton<IAssessmentSeriesService, AssessmentSeriesManager>();
builder.Services.AddSingleton<IAssessmentSeriesDal, EFAssessmentSerieDal>();


builder.Services.AddControllers();

builder.Services.AddCors();

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
app.UseCors(builder => builder.WithOrigins("http://localhost:49213").AllowAnyHeader().AllowAnyOrigin());
app.UseRouting();
app.UseAuthentication();
app.UseStaticFiles();
app.UseAuthorization();


app.MapControllers();

app.Run();
