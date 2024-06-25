using EmployeeSystem.BusinessService;
using EmployeeSystem.BusinessService.Concreate;
using EmployeeSystem.BusinessService.Interface;
using EmployeeSystem.Repository;
using EmployeeSystem.Repository.Concreate;
using EmployeeSystem.Repository.Repository;

namespace EmployeeSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            RepositoryDepedencyContainer.Registration(builder.Services);
            ServiceDepedencyContainer.Registration(builder.Services);
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //builder.Services.AddScoped<IStateDetailRepository,StateDetailRepository>();
            //builder.Services.AddScoped<IStateService, StateService>();       
            //builder.Services.AddScoped<IUserRepository, UserRepository>();
            //builder.Services.AddScoped<IUserService, UserService>();

          

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
