using Prometheus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Blazor Server services
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register calculator service
builder.Services.AddScoped<Calculator.API.Services.ICalculatorService, Calculator.API.Services.CalculatorService>();

// Register HttpClient for API calls
builder.Services.AddHttpClient();

// Add CORS to allow frontend to call the API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseCors("AllowAll");

// Serve static files (including index.html) for the frontend
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();
app.MapBlazorHub();

// Blazor available at /blazor
app.MapFallbackToPage("/blazor/{**path}", "/_Host");

// Prometheus metrics endpoints
app.UseMetricServer();  // Exposes /metrics endpoint
app.UseHttpMetrics();   // Auto-tracks HTTP request metrics

app.Run();
