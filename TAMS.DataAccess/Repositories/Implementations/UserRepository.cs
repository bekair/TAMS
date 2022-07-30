using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserRepository : RepositoryBase<AppUser, TamsDbContext>, IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _userManager;

        public UserRepository(TamsDbContext context, UserManager<AppUser> userManager) : base(context)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> RegisterUserAsync(string email, string userName, string password)
        {
            AppUser newUser = new()
            {
                UserName = userName,
                Email = email,
                IsActive=true,
                CreatedDate = DateTime.Now
            };
            newUser.CreatedBy = newUser.Id;

            return await _userManager.CreateAsync(newUser, password);_userManager.
        }
    }
}
