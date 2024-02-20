using MasterRoleList.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRequiredServices(builder.Configuration, builder.Environment.EnvironmentName);
builder.Services.AddCors(options =>
{
    options.AddPolicy("devCorsPolicy", builder =>
    {
        //builder.WithOrigins("http://localhost:800").AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        //builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
        //builder.SetIsOriginAllowed(origin => true);
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.Use((context, next) =>
    {
        context.Response.Headers["Access-Control-Allow-Origin"] = "*";
        return next.Invoke();
    });
}

app.UseHttpsRedirection();
app.UseCors("devCorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
