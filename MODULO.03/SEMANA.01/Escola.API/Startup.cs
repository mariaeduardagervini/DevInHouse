﻿using Escola.API.DataBase;
using Escola.API.DataBase.Repositories;
using Escola.API.Interfaces.Repositories;
using Escola.API.Interfaces.Services;
using Escola.API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;


namespace Escola.API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc(config =>
        {
            config.ReturnHttpNotAcceptable = true;
            config.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());
            config.InputFormatters.Add(new XmlDataContractSerializerInputFormatter(config));
        });


        var jwtChave = Configuration.GetSection("jwtTokenChave").Get<string>();
        services.AddAuthentication(x =>
        {
            x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(x =>
        {
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtChave)),
                ValidateIssuer = false,
                ValidateAudience = false


            };
        });

        services.AddDbContext<DbContexto>(ServiceLifetime.Transient);
        services.AddTransient<IUsuarioRepository, UsuarioRepository>();

        services.AddTransient<IAutenticacaoServices, AutenticacaoServices>();
        services.AddTransient<IUsuarioService, UsuarioServices>();


        services.AddControllers();

        services.AddScoped<IAlunoService, AlunoService>();
        services.AddScoped<IBoletimServices, BoletimService>();
        
        services.AddDbContext<EscolaDbContexto>();       
        services.AddScoped<IAlunoRepository, AlunoRepository>();
        services.AddScoped<ITurmaRepository, TurmaRepository>();
        services.AddScoped<IBoletimRepository, BoletimRepository>();

        services.AddMemoryCache();



        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Escola.API v1", Version = "v1" });
          
            c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
            {
                Description = @"JWT Authorization header using the Bearer scheme. 
                                              Escreva 'Bearer' [espaço] e o token gerado no login na caixa abaixo.
                                              Exemplo: 'Bearer 12345abcdef'",
                Name = "Authorization",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer"
            });
            c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                                          {
                                            {
                                              new OpenApiSecurityScheme
                                              {
                                                Reference = new OpenApiReference
                                                  {
                                                    Type = ReferenceType.SecurityScheme,
                                                    Id = JwtBearerDefaults.AuthenticationScheme
                                                  },
                                                },
                                                new List<string>()
                                              }
                                            });
        });
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Escola.API v1"));
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}