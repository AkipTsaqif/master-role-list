using MasterRoleList.Interfaces;
using MasterRoleList.Models;
using MasterRoleList.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MasterRoleList.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddRequiredServices(this IServiceCollection services, IConfiguration configuration, string environmentName)
        {
            services.AddControllers().AddNewtonsoftJson(
                options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                });

            services.AddHttpContextAccessor();

            services.AddDbContext<Master_ApprovalContext>(
                opt =>
                {
                    opt.UseSqlServer(configuration.GetConnectionString("MasterApprovalConn"));
                    if (!environmentName.Equals("Production", StringComparison.InvariantCultureIgnoreCase))
                    {
                        opt.EnableSensitiveDataLogging();
                    }
                });

            services.AddDbContext<IT_SupportContext>(
                opt =>
                {
                    opt.UseSqlServer(configuration.GetConnectionString("ITSupportConn"));
                    if (!environmentName.Equals("Production", StringComparison.InvariantCultureIgnoreCase))
                    {
                        opt.EnableSensitiveDataLogging();
                    }
                });

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("*", "*")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
            });

            services.AddScoped<IUserDetailsService, UserDetailsService>();
            services.AddScoped<IUserDetailsRepo, UserDetailsRepo>();

            services.AddScoped<IUserRoleRepo, UserRoleRepo>();
            services.AddScoped<IUserRoleService, UserRoleService>();

            services.AddScoped<ISaveUserRoleService, SaveUserRoleService>();
            services.AddScoped<ISaveUserRoleRepo, SaveUserRoleRepo>();

            services.AddScoped<IDeleteUserRoleService, DeleteUserRoleService>();
            services.AddScoped<IDeleteUserRoleRepo, DeleteUserRoleRepo>();

            return services;
        }
    }
}
