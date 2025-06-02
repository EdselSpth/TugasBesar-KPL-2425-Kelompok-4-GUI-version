using JadwalAPI.Configuration;
using JadwalAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Daftarkan konfigurasi JadwalSettings dari appsettings.json
builder.Services.Configure<JadwalSettings>(
    builder.Configuration.GetSection("JadwalSettings"));

// Daftarkan service JadwalService
builder.Services.AddSingleton<IJadwalService, JadwalService>();

// Tambahkan controller dan swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware swagger di development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
