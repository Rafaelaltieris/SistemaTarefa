using Microsoft.EntityFrameworkCore;
using SistemaTarefa.Data;
using SistemaTarefa.Repositorios.Interfaces;
using SistemaTarefa.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Instanciando os Repositorios e Interfaces, sempre adicione aqui seus Repositório e Interfaces*/
builder.Services.AddScoped<ITarefaRepositorio, TarefaRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
/*Adicionando a nossa string de conexão*/
builder.Services.AddDbContext<SistemaTarefasDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
);

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
