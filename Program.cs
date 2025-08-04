using API_Financas.Data.Repositories;
using API_Financas.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

builder.Services.AddDbContext<FinancasContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<TransacaoRepository>();
builder.Services.AddScoped<CategoriaRepository>();

builder.Services.AddControllers(); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
