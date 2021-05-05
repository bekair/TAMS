using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Implementations;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.DataAccess.UnitOfWork.Implementations;
using TAMS.DataAccess.UnitOfWork.Interfaces;
using TAMS.Entity.Concrete;
using TAMS.Services.Implementations;
using TAMS.Services.Interfaces;

namespace TAMS.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //DbContext DI
            services.AddDbContext<TamsDbContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("TamsDbConnection"),
                    o => o.MigrationsAssembly(typeof(TamsDbContext).Assembly.FullName)
                );
            });

            //IdentityServer DI
            services.AddIdentity<AppUser, Role>()
                    .AddEntityFrameworkStores<TamsDbContext>()
                    .AddDefaultTokenProviders();

            //UnitOfWork DI
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //Repositories DI
            AddRepositoryDependencies(services);

            //Business Service DI
            AddBusinessServiceDependencies(services);

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TAMS.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TAMS.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        //Add Repository dependencies
        private static void AddRepositoryDependencies(IServiceCollection services)
        {
            services.AddScoped<IAcademyAddressRepository, AcademyAddressRepository>();
            services.AddScoped<IAcademyRepository, AcademyRepository>();
            services.AddScoped<IClubAddressRepository, ClubAddressRepository>();
            services.AddScoped<IClubRepository, ClubRepository>();
            services.AddScoped<IRoleClaimRepository, RoleClaimRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ITennisCoachRepository, TennisCoachRepository>();
            services.AddScoped<ITennisCourtRepository, TennisCourtRepository>();
            services.AddScoped<ITennisCourtScheduleRepository, TennisCourtScheduleRepository>();
            services.AddScoped<ITennisTraineeAddressRepository, TennisTraineeAddressRepository>();
            services.AddScoped<ITennisTraineeRepository, TennisTraineeRepository>();
            services.AddScoped<ITennisTrainingPackageInformationRepository, TennisTrainingPackageInformationRepository>();
            services.AddScoped<ITennisTrainingPackageRepository, TennisTrainingPackageRepository>();
            services.AddScoped<ITennisTrainingRepository, TennisTrainingRepository>();
            services.AddScoped<IUserClaimRepository, UserClaimRepository>();
            services.AddScoped<IUserLoginRepository, UserLoginRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<IUserTokenRepository, UserTokenRepository>();
        }

        //Add Business Service dependencies
        private static void AddBusinessServiceDependencies(IServiceCollection services)
        {
            services.AddTransient<IAcademyAddressService, AcademyAddressService>();
            services.AddTransient<IAcademyService, AcademyService>();
            services.AddTransient<IClubAddressService, ClubAddressService>();
            services.AddTransient<IClubService, ClubService>();
            services.AddTransient<IRoleClaimService, RoleClaimService>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<ITennisCoachService, TennisCoachService>();
            services.AddTransient<ITennisCourtService, TennisCourtService>();
            services.AddTransient<ITennisCourtScheduleService, TennisCourtScheduleService>();
            services.AddTransient<ITennisTraineeAddressService, TennisTraineeAddressService>();
            services.AddTransient<ITennisTraineeService, TennisTraineeService>();
            services.AddTransient<ITennisTrainingPackageInformationService, TennisTrainingPackageInformationService>();
            services.AddTransient<ITennisTrainingPackageService, TennisTrainingPackageService>();
            services.AddTransient<ITennisTrainingService, TennisTrainingService>();
            services.AddTransient<IUserClaimService, UserClaimService>();
            services.AddTransient<IUserLoginService, UserLoginService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRoleService, UserRoleService>();
            services.AddTransient<IUserTokenService, UserTokenService>();
        }
    }
}
