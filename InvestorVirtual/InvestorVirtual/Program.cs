namespace InvestorVirtual.Web;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using InvestorVirtual.Data;
using InvestorVirtual.Services.Core;
using InvestorVirtual.Services.Core.Contracts;
using InvestorVirtual.Web.Infrastructure.Extensions;


public class Program
{
    const string LocalDevAndSameOriginPolicy = "LocalDevAndSameOriginPolicy";

    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                IdentityConfigurationOptions(options, builder.Configuration);
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();
        builder.Services.AddControllersWithViews(options =>
        {
            options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
        });

        builder.Services.AddCors(options =>
        {
            options.AddPolicy(LocalDevAndSameOriginPolicy, policy =>
            {
                // TODO: Configure CORS policy for local development and same-origin requests
                policy.AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });

        builder.Services.RegisterRepositoriesFromAssembly(typeof(ApplicationDbContext).Assembly);

        builder.Services.AddScoped<IHomeService, HomeService>();
        builder.Services.AddScoped<ILearningService, LearningService>();
        builder.Services.AddScoped<IInvestmentService, InvestmentService>();
        builder.Services.AddScoped<ITermCategoryService, TermCategoryService>();
        builder.Services.AddScoped<IDaySimulationService, DaySimulationService>();

        WebApplication app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();

        app.UseCors(LocalDevAndSameOriginPolicy);

        app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapStaticAssets();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}")
            .WithStaticAssets();
        app.MapRazorPages()
           .WithStaticAssets();

        app.Run();
    }

    private static void IdentityConfigurationOptions(IdentityOptions options, IConfiguration configuration)
    {
        options.Password.RequireDigit = configuration
            .GetValue<bool>("Identity:Password:RequireDigit");
        options.Password.RequiredLength = configuration
            .GetValue<int>("Identity:Password:RequiredLength");
        options.Password.RequiredUniqueChars = configuration
            .GetValue<int>("Identity:Password:RequiredUniqueChars");
        options.Password.RequireNonAlphanumeric = configuration
            .GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
        options.Password.RequireUppercase = configuration
            .GetValue<bool>("Identity:Password:RequireUppercase");
        options.Password.RequireLowercase = configuration
            .GetValue<bool>("Identity:Password:RequireLowercase");

        options.SignIn.RequireConfirmedAccount = configuration
            .GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
        options.SignIn.RequireConfirmedEmail = configuration
            .GetValue<bool>("Identity:SignIn:RequireConfirmedEmail");
        options.SignIn.RequireConfirmedPhoneNumber = configuration
            .GetValue<bool>("Identity:SignIn:RequireConfirmedPhoneNumber");

        options.User.RequireUniqueEmail = configuration
            .GetValue<bool>("Identity:User:RequireUniqueEmail");
    }
}