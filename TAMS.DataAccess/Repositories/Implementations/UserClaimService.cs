﻿using TAMS.DataAccess.Contexts.EF;
using TAMS.DataAccess.Repositories.Abstracts;
using TAMS.DataAccess.Repositories.Interfaces;
using TAMS.Entity.Concrete;

namespace TAMS.DataAccess.Repositories.Implementations
{
    public class UserClaimService : RepositoryBase<UserClaim, TamsDbContext>, IUserClaimRepository
    {
        public UserClaimService(TamsDbContext context) : base(context)
        {
        }
    }
}
