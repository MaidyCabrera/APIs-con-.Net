using webapi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Conexion a Base de datos desde appsettings.json
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("cnHomeworks"));

builder.Services.AddScoped<IHelloWordService, HelloWorldService>();
// Es lo mismo anterior, pero si necesito mandar un parametro se debe crear el objeto
// builder.Services.AddScoped<IHelloWordService>(p=> new HelloWorldService());
builder.Services.AddScoped<ICategoriaService, CategoriaService>();
builder.Services.AddScoped<ItareasService, TareasService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();
// app.UseWelcomePage();
// app.UseTimeMiddleware();

app.MapControllers();

app.Run();
