using FitnessCenter.Api;
using FitnessCenter.Core.Repositories;
using FitnessCenter.Core.Services;
using FitnessCenter.Data;
using FitnessCenter.Data.Repositories;
using FitnessCenter.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//building secretary
builder.Services.AddScoped<ISecretaryService, SecretaryService>();
//builder.Services.AddScoped<ISecretaryRepository, SecretaryRepository>();

//building guide
builder.Services.AddScoped<IGuideService, GuideService>();
//builder.Services.AddScoped<IGuideRepository, GuideRepository>();

//building gymnast 
builder.Services.AddScoped<IGymnastService, GymnastService>();
//builder.Services.AddScoped<IGymnastRepository, GymnastRepository>();

//building DB
//builder.Services.AddSingleton<DataContext>();
builder.Services.AddDbContext<DataContext>();

//for generic repository
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));

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
