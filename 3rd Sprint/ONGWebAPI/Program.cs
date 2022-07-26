using ONGWebAPI.Repository;
using ONGWebAPI.Repository.EntityRepository;
using ONGWebAPI.Repository.EntityRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuração da injeção de dependência
builder.Services.AddSingleton<ONGContext>((x) => new ONGContext(builder.Configuration.GetValue<bool>("UsarBancoEmMemoria")));

builder.Services.AddSingleton<IUsuarioRepository, EntityUsuarioRepository>();
builder.Services.AddSingleton<IAnimalRepository, EntityAnimalRepository>();



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
