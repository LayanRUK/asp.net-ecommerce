using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Npgsql;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sda_onsite_2_csharp_backend_teamwork.src.Services;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(Program).Assembly);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var _config = builder.Configuration;
var dataSourceBuilder = new NpgsqlDataSourceBuilder(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Database={_config["Db:Database"]};Password={_config["Db:Password"]}");
dataSourceBuilder.MapEnum<Role>();
var dataSource = dataSourceBuilder.Build();
builder.Services.AddDbContext<DatabaseContext>((options) =>
{
    options.UseNpgsql(dataSource).UseSnakeCaseNamingConvention();
});

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


builder.Services.AddDbContext<DatabaseContext>();


builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>();
builder.Services.AddScoped<IOrderItemService, OrderItemService>();


builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();


// add dependency injection
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();



var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins(builder.Configuration["Cors:Origin"]!)
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .SetIsOriginAllowed((host)=>true)
                          .AllowCredentials();
                      });
});


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SigningKey"]!))
        };
    });
var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseCors(MyAllowSpecificOrigins);
app.Run();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthentication();
app.UseAuthorization();