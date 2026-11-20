using RestApiLab.Middleware;
using RestApiLab.Services;

var builder = WebApplication.CreateBuilder(args);

// ---------- Services ----------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IStudentRepository, InMemoryStudentRepository>();

var app = builder.Build();

// ---------- Middleware pipeline (order matters) ----------
app.UseMiddleware<GlobalExceptionMiddleware>();   // 1st: wraps everything below in try/catch
app.UseMiddleware<RequestTimingMiddleware>();     // 2nd: logs and times each request

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
