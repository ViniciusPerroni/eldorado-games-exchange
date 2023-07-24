using GamesExchange.DataAccess.EntityFramework.Exchanges.Repositories;
using GamesExchange.DataAccess.EntityFramework.Games.Repositories;
using GamesExchange.DataAccess.EntityFramework.Identification.Repositories;
using GamesExchange.Model.Exchanges.Repositories;
using GamesExchange.Model.Games.Repositories;
using GamesExchange.Model.Identification.Repositories;

using Identification = GamesExchange.Application.Identification;
using Games = GamesExchange.Application.Games;

using Microsoft.AspNetCore.Authentication.Cookies;
using GamesExchange.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using GamesExchange.WebMvc.Services.Impl;
using GamesExchange.WebMvc.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<GamesExchangeDbContext>(options =>
    options.UseSqlServer(connectionString, options =>
           {
               options.MigrationsAssembly(typeof(GamesExchangeDbContext).Assembly.GetName().Name);
           })
        .UseLazyLoadingProxies()
);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new PathString("/Login/Index/");
        options.AccessDeniedPath = new PathString("/Login/Index/");
    });

builder.Services.AddTransient<IAuthenticationService, AuthenticationService>();

#region Repositories
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPersonRepository, PersonRepository>();
builder.Services.AddTransient<IGameRepository, GameRepository>();
builder.Services.AddTransient<IExchangeRepository, ExchangeRepository>();
#endregion

#region UseCases
//Identification.Person
builder.Services.AddTransient<Identification.Person.Create.IUseCase, Identification.Person.Create.UseCase>();
builder.Services.AddTransient<Identification.Person.Delete.IUseCase, Identification.Person.Delete.UseCase>();
builder.Services.AddTransient<Identification.Person.Edit.IUseCase, Identification.Person.Edit.UseCase>();
builder.Services.AddTransient<Identification.Person.GetById.IUseCase, Identification.Person.GetById.UseCase>();
builder.Services.AddTransient<Identification.Person.List.IUseCase, Identification.Person.List.UseCase>();
builder.Services.AddTransient<Identification.Person.ListAllToDictionary.IUseCase, Identification.Person.ListAllToDictionary.UseCase>();
//Identification.User
builder.Services.AddTransient<Identification.User.Create.IUseCase, Identification.User.Create.UseCase>();
builder.Services.AddTransient<Identification.User.Delete.IUseCase, Identification.User.Delete.UseCase>();
builder.Services.AddTransient<Identification.User.Edit.IUseCase, Identification.User.Edit.UseCase>();
builder.Services.AddTransient<Identification.User.GetById.IUseCase, Identification.User.GetById.UseCase>();
builder.Services.AddTransient<Identification.User.GetByUsernameAndPassword.IUseCase, Identification.User.GetByUsernameAndPassword.UseCase>();
builder.Services.AddTransient<Identification.User.List.IUseCase, Identification.User.List.UseCase>();
//Games.Game
builder.Services.AddTransient<Games.Game.Create.IUseCase, Games.Game.Create.UseCase>();
builder.Services.AddTransient<Games.Game.Delete.IUseCase, Games.Game.Delete.UseCase>();
builder.Services.AddTransient<Games.Game.Edit.IUseCase, Games.Game.Edit.UseCase>();
builder.Services.AddTransient<Games.Game.GetById.IUseCase, Games.Game.GetById.UseCase>();
builder.Services.AddTransient<Games.Game.List.IUseCase, Games.Game.List.UseCase>();
//Exchanges.Exchange
#endregion

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
