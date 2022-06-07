

using Aplicacion.Map;
using AutoMapper;
using Infroestructura.Contexto;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//agrega la instancia a la base de datos y su conexion 
builder.Services.AddDbContext<gv0013_devContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("Test")));


//agrega perfil de mapeo
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddAutoMapper(typeof(MappingProfile));

//agrega los servicios registrados 
builder.Services.Repositorio();
builder.Services.Servicios();

builder.Services.AddControllers();
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
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();