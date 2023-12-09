using AxiaBackend;
using AxiaBackend.CustomMiddleware;
using AxiaBackend.DependancyInjection;
using AxiaBackend.Interfaces;
using AxiaBackend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using AxiaBackend.Model.DTO;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using Microsoft.AspNetCore.DataProtection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IConsoleWriter,ConsoleWriter>();
//cnx DB
builder.Services.AddDbContext<AppDataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("axiaRessource")));


//entities
builder.Services.AddTransient<IGroupeService, GroupeService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IPaiementService, PaiementService>();
builder.Services.AddTransient<IObjectifsService, ObjectifsService>();
builder.Services.AddTransient<IPointageService, PointageService>();
builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<ITacheService, TacheService>();
builder.Services.AddTransient<IAccessoireService, AccessoireService>();
builder.Services.AddTransient<ICongesService, CongesService>();
builder.Services.AddTransient<IAttachementService, AttachementService>();
builder.Services.AddTransient<ILogService, LogService>();
builder.Services.AddTransient<ITypeCongesService, TypeCongesService>();
builder.Services.AddTransient<IUserService, UserService>();

//builder.Services.AddDataProtection().PersistKeysToFileSystem(new DirectoryInfo(@"C:\temp-keys\"))
//                .UseCryptographicAlgorithms(new AuthenticatedEncryptorConfiguration()
//                {
//                    EncryptionAlgorithm = EncryptionAlgorithm.AES_256_CBC,
//                    ValidationAlgorithm = ValidationAlgorithm.HMACSHA256
//                });

var _jwtsetting = builder.Configuration.GetSection("JWTSetting");
builder.Services.Configure<JWTSetting>(_jwtsetting);
var authkey = builder.Configuration.GetValue<string>("Appsetting:my top secret key");

builder.Services.AddAuthentication(auth =>
{ 
auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
auth.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(options =>
{

    //item.RequireHttpsMetadata = false;
    //item.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
        ValidateIssuer = false,
        ValidateAudience = false,
        //ValidateLifetime = true,
        //ClockSkew = TimeSpan.Zero
    };
});

var _dbcontext = builder.Services.BuildServiceProvider().GetService<AppDataContext>();

builder.Services.AddSingleton(builder.Configuration);

//ajout swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title="swagger",Version="v1"});
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        //Scheme = "Bearer",
        //BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "standard Authorization header using the Bearer scheme"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
}

);
var app = builder.Build();
//configuration Cors
app.UseCors(options => options.WithOrigins("http://localhost:3011").AllowAnyMethod().AllowAnyHeader());

//enbale middleware
app.UseSwagger();
//Configuration swagger 
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "ASP Net React");
});
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions()
{

});

//app.UseCors(x=>x.AllowAnyMethod().AllowAnyHeader().SetIsOriginAllowed(origin=>true));
app.UseMyMiddleware();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");
app.MapFallbackToFile("index.html");

app.Run();




