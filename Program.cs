using FornecedorAPI.Business.Helpers;
using Microsoft.AspNetCore.Mvc;
using Plamove.Business.Services.AvisoService;
using Plamove.Business.Services.FornecedorService;
using Playmove.Data;
using Playmove.Data.Interfaces;
using Playmove.Data.Repository;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddResolveDependencies();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
