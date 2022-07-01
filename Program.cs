var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors();
builder.Services.AddSwaggerGen(c=>{
    c.SwaggerDoc("v1",
    new Microsoft.OpenApi.Models.OpenApiInfo{
        
                Title = "zkAccess",
                Version = "v1",
                Description = "api web acceso",
    });
});

//add automapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
//clave auth
//conect database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//archivos estaticos
app.UseStaticFiles();
app.UseHttpsRedirection();
//uso de cors
app.UseCors(
    c=> c.AllowAnyHeader().AllowAnyHeader().AllowAnyOrigin()
);
app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:5000");
